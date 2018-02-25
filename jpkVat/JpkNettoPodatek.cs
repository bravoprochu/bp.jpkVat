using System;

namespace bp.jpkVat
{
    public class JpkNettoPodatek
    {
        private double? netto;

        public double? Netto
        {
            get
            {
                if (netto.HasValue)
                {
                    return Math.Round(netto.Value, 2);
                }
                else {
                    return null;
                }
            }
            set { netto = value; }
        }

        private double? podatek;

        public double? Podatek
        {
            get
            {
                if (podatek.HasValue)
                {
                    return Math.Round(podatek.Value, 2);
                }
                else { return null; }
            }
            set { podatek = value; }
        }



    }
}