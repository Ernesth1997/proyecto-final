using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Interfaces
{
    public interface IDao2<A>
    {
        void Insert();
        void Delete(A a);
        void Update(A a);
        DataTable Select();
    }
}
