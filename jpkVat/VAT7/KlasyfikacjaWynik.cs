using System;
using System.Collections.Generic;
using System.Text;

namespace bp.jpkVat.VAT7
{
    public class KlasyfikacjaWynik
    {
        public KlasyfikacjaWynik()
        {
            this.PodatekList = new List<int?>();
            this.PodstawaList = new List<int?>();
        }
        public List<int?> PodstawaList { get; set; }
        public List<int?> PodatekList { get; set; }
    }
}
