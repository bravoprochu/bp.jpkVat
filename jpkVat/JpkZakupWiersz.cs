using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bp.jpkVat
{
    public class JpkZakupWiersz
    {
        public JpkZakupWiersz()
        {
            this.K_43__K_44 = new JpkNettoPodatek();
            this.K_45__K_46 = new JpkNettoPodatek();
        }
        
        public int LpZakupu { get; set; }
        [MinLength(4)]
        private string _nrDostawcy { get; set; }
        [MaxLength(10)]
        public string NrDostawcy
        {
            get
            {
                string res = "brak";
                if (_nrDostawcy?.Length < 10) {
                    return res;
                }
                int v = -1;
                var last4 = String.Join("", _nrDostawcy.ToCharArray().TakeLast(4));
                bool canParse = Int32.TryParse(last4, out v);
                return canParse ? string.Join("", _nrDostawcy.ToCharArray().TakeLast(10)) : res;
            }
            set { this._nrDostawcy = value; }
        }
        private string _nazwaDostawcy;
        public string NazwaDostawcy
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_nazwaDostawcy))
                {
                    return _nazwaDostawcy.Replace((char)34, (char)39);
                }
                else {
                    return null;
                }
            }
            set { _nazwaDostawcy = value; }
        }
        private string _adresDostawcy { get; set; }
        public string AdresDostawcy { get {
                if (!string.IsNullOrWhiteSpace(_adresDostawcy))
                {
                    return _adresDostawcy.Replace((char)34, (char)39);
                }
                else { return null; }
            } set {
                _adresDostawcy = value;
            } }
        public string DowodZakupu { get; set; }
        public DateTime DataZakupu { get; set; }
        public DateTime DataWplywu { get; set; }
        public JpkNettoPodatek K_43__K_44 { get; set; }
        public JpkNettoPodatek K_45__K_46 { get; set; }
        private double? k_47 { get; set; }
        public double? K_47 { get { if (k_47.HasValue) { return Math.Round(k_47.Value, 2); } else { return null; } } set { k_47 = value.Value; } }
        private double? k_48 { get; set; }
        public double? K_48 { get { if (k_48.HasValue) { return Math.Round(k_48.Value, 2); } else { return null; } } set { k_48 = value.Value; } }
        private double? k_49 { get; set; }
        public double? K_49 { get { if (k_49.HasValue) { return Math.Round(k_49.Value, 2); } else { return null; } } set { k_49 = value.Value; } }
        private double? k_50 { get; set; }
        public double? K_50 { get { if (k_50.HasValue) { return Math.Round(k_50.Value, 2); } else { return null; } } set { k_50 = value.Value; } }
    }
}
