using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizadorAmigosWebApp.Interfaces;

namespace LocalizadorAmigosWebApp.Models
{
    public class Amigo : IAmigo
    {
        private int _Id;
        private string _Nome;

        public Amigo()
        {
        }

        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Nome {
            get { return _Nome; }
            set { _Nome = value; }
        }
    }
}
