using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bp.jpkVat
{
    public class JpkPodmiot
    {
        [MinLength(4)]
        private string _nip { get; set; }
        [MaxLength(10)]
        public string NIP
        {
            get
            {
                string res = "brak";
                if (_nip?.Length < 10)
                {
                    return res;
                }
                int v = -1;
                var last4 = String.Join("", _nip.ToCharArray().TakeLast(4));
                bool canParse = Int32.TryParse(last4, out v);
                return canParse ? string.Join("", _nip.ToCharArray().TakeLast(10)) : res;
            }
            set { this._nip = value; }
        }
        private string pelnaNazwa;
        public string PelnaNazwa
        {
            get
            {
                return pelnaNazwa.Replace((char)34, (char)36);
            }
            set { pelnaNazwa = value; }
        }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
