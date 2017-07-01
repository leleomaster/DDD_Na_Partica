using DDD_Na_Partica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Na_Partica.Application.IppServices
{
    public interface IAppServiceUsuario
    {
        Usuario LoginUsuario(string senha, string usuario);
    }
}
