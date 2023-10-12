using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Letra.Models
{
    public class Oyunlarimiz
    {
        [Key]
        public int Id { get; set; }
        public string OyunAdi { get; set; }
        public string OyunAciklamasi { get; set; }
        public string OyunFotografi { get; set; }
        public string OyunLinki { get; set; }
    }
}