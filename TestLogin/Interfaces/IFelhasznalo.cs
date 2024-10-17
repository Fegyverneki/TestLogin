using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using TestLogin.Models;

namespace TestLogin.Interfaces
{
    [ServiceContract]
    public interface IFelhasznalo
    {
        [OperationContract]
        List<Felhasznalo> FelhasznaloLista();

        [OperationContract]
        string UjFelhasznalo(Felhasznalo felhasznalo);

        [OperationContract]
        string ModositFelhasznalo(Felhasznalo felhasznalo);

        [OperationContract]
        string TorolFelhasznalo(int id);
    }
}
