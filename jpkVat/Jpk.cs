using bp.shared.StringHelp;
using System.Text;

namespace bp.jpkVat
{
    public class Jpk
    {
        public Jpk()
        {
            this.Naglowek = new JpkNaglowek();
            this.Podmiot = new JpkPodmiot();
            this.Sprzedaz = new JpkSprzedaz();
            this.Zakup = new JpkZakup();
        }
        public JpkNaglowek Naglowek { get; set; }
        public JpkPodmiot Podmiot { get; set; }
        public JpkSprzedaz Sprzedaz { get; set; }
        public JpkZakup Zakup { get; set; }
        public StringBuilder ConvertToStringBuilder()
        {
            var dateClassicFormat = bp.shared.DateHelp.DateHelpful.DateFormatClassic();
            var dateTimeClassicFormat = bp.shared.DateHelp.DateHelpful.DateTimeFormatClassic();

            StringBuilder sb = new StringBuilder();
            var n = this.Naglowek;
            var p = this.Podmiot;
            var s = this.Sprzedaz;
            var z = this.Zakup;
            sb.AppendLine(@"KodFormularza;kodSystemowy;wersjaSchemy;WariantFormularza;CelZlozenia;DataWytworzeniaJPK;DataOd;DataDo;NazwaSystemu;NIP;PelnaNazwa;Email;LpSprzedazy;NrKontrahenta;NazwaKontrahenta;AdresKontrahenta;DowodSprzedazy;DataWystawienia;DataSprzedazy;K_10;K_11;K_12;K_13;K_14;K_15;K_16;K_17;K_18;K_19;K_20;K_21;K_22;K_23;K_24;K_25;K_26;K_27;K_28;K_29;K_30;K_31;K_32;K_33;K_34;K_35;K_36;K_37;K_38;K_39;LiczbaWierszySprzedazy;PodatekNalezny;LpZakupu;NrDostawcy;NazwaDostawcy;AdresDostawcy;DowodZakupu;DataZakupu;DataWplywu;K_43;K_44;K_45;K_46;K_47;K_48;K_49;K_50;LiczbaWierszyZakupow;PodatekNaliczony;");
            sb.AppendLine($"JPK_VAT;{n.KodFormularza.KodSystemowy};{n.KodFormularza.WersjaSchemy};{n.WariantFormularza};{n.CelZlozenia};{n.DataWytworzeniaJPK.ToString(dateTimeClassicFormat)};{n.DataOd.ToString(dateClassicFormat)};{n.DataDo.ToString(dateClassicFormat)};{n.NazwaSystemu}");
            //
            var pominieteKolumny = new string(';', 9); //9 kolumn
            sb.AppendLine($"{pominieteKolumny}{StringHelpful.Nip10LastChars(p.NIP)};{p.PelnaNazwa};{p.Email}");

            pominieteKolumny = new string(';', 12); //12 kolumny
            foreach (var w in s.SprzedazWiersz)
            {
                sb.AppendLine($"{pominieteKolumny}{w.LpSprzedazy};{w.NrKontrahenta};{w.NazwaKontrahenta};{w.AdresKontrahenta};{w.DowodSprzedazy};{w.DataWystawienia.ToString(dateClassicFormat)};{w.DataSprzedazy.ToString(dateClassicFormat)};{w.K_10};{w.K_11};{w.K_12};{w.K_13};{w.K_14};{w.K_15__K_16.Netto};{w.K_15__K_16.Podatek};{w.K_17__K_18.Netto};{w.K_17__K_18.Podatek};{w.K_19__K_20.Netto};{w.K_19__K_20.Podatek};{w.K_21};{w.K_22};{w.K_23__K_24.Netto};{w.K_23__K_24.Podatek};{w.K_25__K_26.Netto};{w.K_25__K_26.Podatek};{w.K_27__K_28.Netto};{w.K_27__K_28.Podatek};{w.K_29__K_30.Netto};{w.K_29__K_30.Podatek};{w.K_31};{w.K_32__K_33.Netto};{w.K_32__K_33.Podatek};{w.K_34__K_35.Netto};{w.K_34__K_35.Podatek};{w.K_36};{w.K_37};{w.K_38};{w.K_39}");
            }
            pominieteKolumny = new string(';', 49); //49 kolumn
            sb.AppendLine($"{pominieteKolumny}{s.LiczbaWierszySprzedazy};{s.PodatekNalezny}");
            pominieteKolumny = new string(';', 51); //51 kolumn
            foreach (var w in z.ZakupWiersz)
            {
                sb.AppendLine($"{pominieteKolumny}{w.LpZakupu};{w.NrDostawcy};{w.NazwaDostawcy};{w.AdresDostawcy};{w.DowodZakupu};{w.DataZakupu.ToString(dateClassicFormat)};{w.DataWplywu.ToString(dateClassicFormat)};{w.K_43__K_44.Netto};{w.K_43__K_44.Podatek};{w.K_45__K_46.Netto};{w.K_45__K_46.Podatek};{w.K_47};{w.K_48};{w.K_49};{w.K_50}");
            }
            pominieteKolumny = new string(';', 66); //66 kolumn
            sb.AppendLine($"{pominieteKolumny}{z.LiczbaWierszyZakupow};{z.PodatekNaliczony}");
            return sb;
        }
    }
}
