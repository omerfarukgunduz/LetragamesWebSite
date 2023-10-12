﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Letra.Models
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string LogoLink { get; set; }
    }
}