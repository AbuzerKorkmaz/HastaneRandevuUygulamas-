using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuUygulaması
{
    public class Hasta
    {
        public string AdSoyAd { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public string Poliklinic { get; set; }
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }

        public override string ToString()
        {
            return $"{AdSoyAd}- {Poliklinic} -{Tarih.ToShortDateString()} - {Saat} ";
        }
    }
}
