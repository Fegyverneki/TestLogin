using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TestLogin.Controllers;
using TestLogin.Interfaces;
using TestLogin.Models;

namespace TestLogin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Felhasznalo> FelhasznaloLista()
        {
            List<Rekord> rlist = new FelhasznaloController().Select();
            List<Felhasznalo> flist = new List<Felhasznalo>();
            foreach (Rekord rekord in rlist)
            {
                flist.Add(rekord as Felhasznalo);
            }
            return flist;
        }

        public List<Jogosultsag> JogosultsagLista()
        {
            return new List<Jogosultsag>();
        }

        public string ModositFelhasznalo(Felhasznalo felhasznalo)
        {
            return "";
        }

        public string ModositJogosultsag(Jogosultsag jogosultsag)
        {
            return "";
        }

        public string TorolFelhasznalo(int id)
        {
            return "";
        }

        public string TorolJogosultsag(int id)
        {
            return "";
        }

        public string UjFelhasznalo(Felhasznalo felhasznalo)
        {
            return "";
        }

        public string UjJogosultsag(Jogosultsag jogosultsag)
        {
            return "";
        }
    }
}
