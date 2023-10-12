using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Letra.Models
{
    public class İletisim
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string MailAdresi { get; set; }
        public string Mesaj { get; set; }
    }
}