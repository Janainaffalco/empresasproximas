using LocalizadorAmigosWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizadorAmigosWebApp.Interfaces
{
    interface IAmigoLocalizacao
    { 
        Amigo Amigo { get; set; }
        Localizacao Localizacao { get; set; }
    }
}
