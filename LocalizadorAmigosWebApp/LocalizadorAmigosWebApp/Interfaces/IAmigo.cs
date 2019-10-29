using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizadorAmigosWebApp.Interfaces
{
    public interface IAmigo
    {
        int Id { get; set; }
        String Nome { get; set; }
    }
}
