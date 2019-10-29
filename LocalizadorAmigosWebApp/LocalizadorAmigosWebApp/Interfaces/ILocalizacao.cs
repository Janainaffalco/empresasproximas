using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizadorAmigosWebApp.Interfaces
{
    public interface ILocalizacao
    {
        decimal Lat { get; set; }
        decimal Long { get; set; }
    }
}
