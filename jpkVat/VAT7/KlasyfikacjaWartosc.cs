using System;
using System.Collections.Generic;
using System.Text;

namespace bp.jpkVat.VAT7
{
    public class KlasyfikacjaWartosc
    {
        public int KlasyfikacjaWartoscId { get; set; }
        public bool CzySprzedaz { get; set; }
        public string Nazwa { get; set; }
        public KlasyfikacjaWartosc Nadrzedny { get; set; }
        public int Poziom { get {
                int res = 0;
                var nad = Nadrzedny;
                while (nad != null) {
                        nad = nad.Nadrzedny;
                        res++;
                }
                return res;
            } }
        public int? PodstawaId { get; set; }
        public int? PodatekId { get; set; }
        public string Opis { get; set; }
    }
}
