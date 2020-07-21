using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FacebookLoginSel
{
    public class Credentials
    {
         public string email = "";
         public string password = "";
         public string json = "";

         public Credentials()
         {
            using (StreamReader r = new StreamReader("F:\\VS\\Facebook\\Cred.json"))
            {
                json = r.ReadToEnd();
            }

             dynamic array = JsonConvert.DeserializeObject(json);
             Console.WriteLine("Array::::" + array["email"]);
             email = array["email"];
             password = array["password"];
         }
    }
}
