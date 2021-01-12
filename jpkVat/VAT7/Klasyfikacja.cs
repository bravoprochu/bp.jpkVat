using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bp.jpkVat.VAT7
{
    public class Klasyfikacja
    {

        public Klasyfikacja(List<KlasyfikacjaWartosc> klasyfikacjaWartosci)
        {
            this.Wybrany = new KlasyfikacjaWartosc();
            this._klasyfikacjaList = klasyfikacjaWartosci;
            //this._wybranyList = new List<KlasyfikacjaWartosc>();
        }

        private List<KlasyfikacjaWartosc> _klasyfikacjaList { get; set; }
        private List<KlasyfikacjaWartosc> _wybranyList { get; set; }
        private List<KlasyfikacjaPoziom> KlasyfikacjaPoziomyZakup
        {
            get
            {
                var res = new List<KlasyfikacjaPoziom>();

                return _klasyfikacjaList.Where(w => !w.CzySprzedaz).GroupBy(g => g.Poziom).Select(sg => new KlasyfikacjaPoziom
                {
                    KlasyfikacjaList = sg.ToList(),
                    Poziom = sg.Key
                }).ToList();


            }
        }
        public List<KlasyfikacjaWartosc> PoziomNastepny
        {
            get
            {
                return _klasyfikacjaList.Where(w => w.Nadrzedny != null && w.Nadrzedny.KlasyfikacjaWartoscId == Wybrany.KlasyfikacjaWartoscId).ToList();
            }
        }
        public List<KlasyfikacjaPoziom> Poziomy
        {
            get
            {
                var res = new List<KlasyfikacjaPoziom>();
                foreach (var poz in _wybranyList)
                {
                    var _poziomy = _klasyfikacjaList.Where(w => w.Nadrzedny != null && poz.Nadrzedny != null && w.Nadrzedny.KlasyfikacjaWartoscId == poz.Nadrzedny.KlasyfikacjaWartoscId).ToList();
                    if (_poziomy.Count == 0)
                    {
                        _poziomy = _klasyfikacjaList.Where(w => w.Poziom == poz.Poziom).ToList();
                    }
                    res.Add(new KlasyfikacjaPoziom
                    {
                        KlasyfikacjaList = _poziomy,
                        Poziom = poz.Poziom,
                        Wybrany = poz

                    });
                }
                return res.OrderBy(o => o.Poziom).ToList();
            }
        }
        private KlasyfikacjaWartosc _wybrany { get; set; }
        public KlasyfikacjaWartosc Wybrany
        {
            get { return _wybrany; }
            set
            {
                _wybranyList = new List<KlasyfikacjaWartosc>();
                if (value != null)
                {

                    _wybranyList.Add(value);
                }
                var temp = value.Nadrzedny;
                while (temp != null)
                {
                    _wybranyList.Add(temp);
                    if (temp.Nadrzedny != null)
                    {
                        temp = temp.Nadrzedny;
                    }
                    else
                    {
                        temp = null;
                    }
                }

                _wybrany = value;
            }
        }
        public KlasyfikacjaWynik Wynik
        {
            get
            {
                var res = new KlasyfikacjaWynik();
                res.PodatekList = _wybranyList.Where(w => w.PodatekId > 0).Select(s => s.PodatekId).OrderBy(o=>o.Value).ToList();
                res.PodstawaList = _wybranyList.Where(w => w.PodstawaId > 0).Select(s => s.PodstawaId).OrderBy(o=>o.Value).ToList();
                return res;
            }
        }
    }
}
