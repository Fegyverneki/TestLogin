using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestLogin.DataBaseManager;
using TestLogin.Models;

namespace TestLogin.Controllers
{
    public class FelhasznaloController : BaseDataBaseManager, ISQL
    {
        public string Delete(int id)
        {
            return "delete";
        }

        public string Insert(Rekord rekord)
        {
            return "insert";
        }

        public List<Rekord> Select()
        {
            List<Rekord> list = new List<Rekord>();
            MySqlCommand cmd = new MySqlCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT * FROM felhasznalok"
            };
            try
            {
                MySqlConnection conn = BaseDataBaseManager.connection;
                conn.Open();
                cmd.Connection = conn;
                //Eddig az SQL parancs futtatásának előkészítése történt
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Felhasznalo ujfelhasznalo = new Felhasznalo()
                    {
                        Id = reader.GetInt32("Id"),
                        LoginNev = reader.GetString("LoginNev"),
                        HASH = reader.GetString("HASH"),
                        SALT = reader.GetString("SALT"),
                        Nev = reader.GetString("Nev"),
                        Jog = reader.GetInt32("Jog"),
                        Aktiv = reader.GetBoolean("Aktiv"),
                        Email = reader.GetString("Email"),
                        ProfilKep = reader.GetString("ProfilKep")
                    };
                    list.Add(ujfelhasznalo);
                }
            }
            catch (Exception ex)
            {
                Felhasznalo ujFelhasznalo = new Felhasznalo()
                {
                    Id = -1,
                    HASH = ex.Message
                };
                list.Add(ujFelhasznalo);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        public string Update(Rekord rekord)
        {
            return "update";
        }
    }
}