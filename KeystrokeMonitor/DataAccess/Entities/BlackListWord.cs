using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeystrokeMonitor.DataAccess.Entities
{
    public class BlackListWord
    {
        [Key]
        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public int ID { get; set; }
        public string Word { get; set; }
        public string WordCode { get; set; }
        public bool IsSended { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
