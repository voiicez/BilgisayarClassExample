using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarClassExample
{
    internal class Bilgisayar
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Aciklama { get; set; }
        public double Hiz { get; set; }
        public byte Ram { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public DateTime UretimTarihi { get; set; }
    }
}
