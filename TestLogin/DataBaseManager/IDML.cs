using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.Models;

namespace TestLogin.DataBaseManager
{
    internal interface IDML
    {
        string Insert(Rekord rekord);

        string Update(Rekord rekord);

        string Delete(int id);
    }
}
