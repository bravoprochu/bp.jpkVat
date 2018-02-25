using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.jpkVat
{
    public class JpkSprzedaz
    {
        public JpkSprzedaz()
        {
            this.SprzedazWiersz = new List<JpkSprzedazWiersz>();
        }
        public List<JpkSprzedazWiersz> SprzedazWiersz { get; set; }
        public int LiczbaWierszySprzedazy => SprzedazWiersz.Count;
        public double PodatekNalezny
        {
            get
            {
                var k16 = SprzedazWiersz.Sum(k => k.K_15__K_16.Podatek);
                var k18 = SprzedazWiersz.Sum(k => k.K_17__K_18.Podatek);
                var k20 = SprzedazWiersz.Sum(k => k.K_19__K_20.Podatek);
                var k24 = SprzedazWiersz.Sum(k => k.K_23__K_24.Podatek);
                var k26 = SprzedazWiersz.Sum(k => k.K_25__K_26.Podatek);
                var k28 = SprzedazWiersz.Sum(k => k.K_27__K_28.Podatek);
                var k30 = SprzedazWiersz.Sum(k => k.K_29__K_30.Podatek);
                var k33 = SprzedazWiersz.Sum(k => k.K_32__K_33.Podatek);
                var k35 = SprzedazWiersz.Sum(k => k.K_34__K_35.Podatek);
                var k36 = SprzedazWiersz.Sum(k => k.K_36);
                var k37 = SprzedazWiersz.Sum(k => k.K_37);

                var plus = k16.Value + k18.Value + k20.Value + k24.Value + k26.Value + k28.Value + k30.Value + k33.Value + k35.Value + k36.Value + k37.Value;
                var minus = SprzedazWiersz.Sum(k => k.K_38);

                return (plus - minus.Value);
            }
        }
    }
}
