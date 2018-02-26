using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bp.jpkVat
{
    public class JpkSprzedazWiersz
    {
        public JpkSprzedazWiersz()
        {
            K_15__K_16 = new JpkNettoPodatek();
            K_17__K_18 = new JpkNettoPodatek();
            K_19__K_20 = new JpkNettoPodatek();

            K_23__K_24 = new JpkNettoPodatek();
            K_25__K_26 = new JpkNettoPodatek();
            K_27__K_28 = new JpkNettoPodatek();
            K_29__K_30 = new JpkNettoPodatek();
            K_32__K_33 = new JpkNettoPodatek();
            K_34__K_35 = new JpkNettoPodatek();
        }

        public int LpSprzedazy { get; set; }
        [MinLength(4)]
        private string _nrKontrahenta { get; set; }
        [MaxLength(10)]
        public string NrKontrahenta
        {
            get
            {
                string res = "brak";
                if (_nrKontrahenta?.Length < 10)
                {
                    return res;
                }
                int v = -1;
                var last4 = String.Join("", _nrKontrahenta.ToCharArray().TakeLast(4));
                bool canParse = Int32.TryParse(last4, out v);
                return canParse ? string.Join("", _nrKontrahenta.ToCharArray().Take(10)) : res;
            }
            set { this._nrKontrahenta = value; }
        }
        private string _nazwaKontrahent { get; set; }
        public string NazwaKontrahenta { get {
                if (!string.IsNullOrWhiteSpace(_nazwaKontrahent))
                {
                    return _nazwaKontrahent.Replace((char)34, (char)39);
                }
                else {
                    return null;
                }
            } set {
                _nazwaKontrahent = value;
            } }
        private string _adresKontrahent { get; set; }
        public string AdresKontrahenta { get {
                if (string.IsNullOrWhiteSpace(_adresKontrahent)) {
                    return _adresKontrahent.Replace((char)34, (char)39);
                }
                else { return null; }
            } set {
                _adresKontrahent = value;
            } }
        public string DowodSprzedazy { get; set; }
        public DateTime DataWystawienia { get; set; }
        public DateTime DataSprzedazy { get; set; }
        private double? k_10;
        public double? K_10 { get { if (k_10.HasValue) { return Math.Round(k_10.Value, 2); } else { return null; } } set { k_10 = value.Value; } }
        private double? k_11;
        public double? K_11 { get { if (k_11.HasValue) { return Math.Round(k_11.Value, 2); } else { return null; } } set { k_11 = value.Value; } }
        private double? k_12;
        public double? K_12 { get { if (k_12.HasValue) { return Math.Round(k_12.Value, 2); } else { return null; } } set { k_12 = value.Value; } }
        private double? k_13;
        public double? K_13 { get { if (k_13.HasValue) { return Math.Round(k_13.Value, 2); } else { return null; } } set { k_13 = value.Value; } }
        private double? k_14;
        public double? K_14 { get { if (k_14.HasValue) { return Math.Round(k_14.Value, 2); } else { return null; } } set { k_14 = value.Value; } }
        public JpkNettoPodatek K_15__K_16 { get; set; }
        public JpkNettoPodatek K_17__K_18 { get; set; }
        public JpkNettoPodatek K_19__K_20 { get; set; }
        private double? k_21;
        public double? K_21 { get { if (k_21.HasValue) { return Math.Round(k_21.Value, 2); } else { return null; } } set { k_21 = value.Value; } }
        private double? k_22;
        public double? K_22 { get { if (k_22.HasValue) { return Math.Round(k_22.Value, 2); } else { return null; } } set { k_22 = value.Value; } }
        public JpkNettoPodatek K_23__K_24 { get; set; }
        public JpkNettoPodatek K_25__K_26 { get; set; }
        public JpkNettoPodatek K_27__K_28 { get; set; }
        public JpkNettoPodatek K_29__K_30 { get; set; }
        private double? k_31;
        public double? K_31 { get { if (k_31.HasValue) { return Math.Round(k_31.Value, 2); } else { return null; } } set { k_31 = value.Value; } }
        public JpkNettoPodatek K_32__K_33 { get; set; }
        public JpkNettoPodatek K_34__K_35 { get; set; }
        private double? k_36;
        public double? K_36 { get { if (k_36.HasValue) { return Math.Round(k_36.Value, 2); } else { return null; } } set { k_36 = value.Value; } }
        private double? k_37;
        public double? K_37 { get { if (k_37.HasValue) { return Math.Round(k_37.Value, 2); } else { return null; } } set { k_37 = value.Value; } }
        private double? k_38;
        public double? K_38 { get { if (k_38.HasValue) { return Math.Round(k_38.Value, 2); } else { return null; } } set { k_38 = value.Value; } }
        private double? k_39;
        public double? K_39 { get { if (k_39.HasValue) { return Math.Round(k_39.Value, 2); } else { return null; } } set { k_39 = value.Value; } }






    }
}

