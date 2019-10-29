using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizadorAmigosWebApp.Interfaces;

namespace LocalizadorAmigosWebApp.Models
{
    public class Localizacao : ILocalizacao
    {
        private int _Id;
        private int _AmigoId;
        private decimal _Lat;
        private decimal _Long;

        public Localizacao()
        {
        }

        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }
        public int AmigoId {
            get { return _AmigoId; }
            set { _AmigoId = value; }
        }
        public decimal Lat {
            get { return _Lat; }
            set { _Lat = value; }
        }
        public decimal Long {
            get { return _Long; }
            set { _Long = value; }
        }
    }
}
