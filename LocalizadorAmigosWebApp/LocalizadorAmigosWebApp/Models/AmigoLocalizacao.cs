using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizadorAmigosWebApp.Interfaces;

namespace LocalizadorAmigosWebApp.Models
{
    public class AmigoLocalizacao : IAmigoLocalizacao
    {
        private Amigo _Amigo;
        private Localizacao _Localizacao;
        private List<Amigo> _AmigosProximos;

        public AmigoLocalizacao()
        {
        }

        public Amigo Amigo {
            get { return _Amigo; }
            set { _Amigo = value; }
        }

        public Localizacao Localizacao
        {
            get { return _Localizacao; }
            set { _Localizacao = value; }
        }

        public List<Amigo> AmigosProximos
        {
            get { return _AmigosProximos; }
            set { _AmigosProximos = value; }
        }
    }
}
