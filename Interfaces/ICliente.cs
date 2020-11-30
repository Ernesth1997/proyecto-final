using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace Interfaces
{
    public interface ICliente:IDao<MCliente>
    {
        MCliente Get(int id);

    }
}
