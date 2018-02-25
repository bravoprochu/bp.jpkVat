using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bp.jpkVat
{
    public class JpkPodmiot
    {
        [MaxLength(10)]
        public string NIP { get; set; }
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
