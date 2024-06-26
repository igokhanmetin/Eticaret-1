﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eticaret.Model
{
    [Table("Urun")]
    public class Urun
    {
        [Key]

        public Guid Id { get; set; }

        public string Ad { get; set; } = string.Empty;

        public double Fiyat { get; set; }

        public string GorselAd { get; set; } = string.Empty;

        public Guid KategoriId { get; set; }

        [ForeignKey("KategoriId")]

        public virtual Kategori Kategori { get; set; } = new();

        public int Durum { get; set; }

    }
}
