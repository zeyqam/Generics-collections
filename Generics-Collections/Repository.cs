using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections
{
    internal class Repository<T,U> /*where T : class*//*where T:BaseEntity*/ /*where T :new()*/
                                   where T : U
    {
    }
}
