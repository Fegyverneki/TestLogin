using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.Models;

namespace TestLogin.DataBaseManager
{
    internal interface IDQL
    {
        List<Rekord> Select();
    }
}
