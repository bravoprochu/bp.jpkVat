using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bp.jpkVat
{
    public class JpkZakup
    {
        public JpkZakup()
        {
            this.ZakupWiersz = new List<JpkZakupWiersz>();
        }

        public List<JpkZakupWiersz> ZakupWiersz { get; set; }
        public int LiczbaWierszyZakupow => ZakupWiersz.Count;
        public double PodatekNaliczony { get {
                var k44 = ZakupWiersz.Sum(z => z.K_43__K_44.Podatek);
                var k46 = ZakupWiersz.Sum(z => z.K_45__K_46.Podatek);
                var k47 = ZakupWiersz.Sum(z => z.K_47);
                var k48 = ZakupWiersz.Sum(z => z.K_48);
                var k49 = ZakupWiersz.Sum(z => z.K_49);
                var k50 = ZakupWiersz.Sum(z => z.K_50);

                var plus = k44.Value + k46.Value + k47.Value + k48.Value + k49.Value + k50.Value;

                return Math.Round(plus,2);
            } }
    }
}
