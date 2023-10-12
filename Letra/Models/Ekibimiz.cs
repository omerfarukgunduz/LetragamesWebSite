using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Letra.Models
{
    public class Ekibimiz
    {
        [Key]
        public int Id { get; set; }
        public string UyeAdSoyad { get; set; }
        public string UyePozisyon { get; set; }
        public string UyeFotograf { get; set; }
        public string UyeLinkedin { get; set; }
        public string UyeGithub { get; set; }
        public string UyeMail { get; set; }
    }
}