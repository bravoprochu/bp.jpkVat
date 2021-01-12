using System;
using System.Collections.Generic;
using System.Text;

namespace bp.jpkVat.VAT7
{
    public class KlasyfikacjaPoziom
    {
        public KlasyfikacjaPoziom()
        {
            this.KlasyfikacjaList = new List<KlasyfikacjaWartosc>();
        }
        public int Poziom { get; set; }
        public List<KlasyfikacjaWartosc> KlasyfikacjaList { get; set; }
        public int Count => KlasyfikacjaList.Count;
        public KlasyfikacjaWartosc Wybrany { get; set; }

    }
}
