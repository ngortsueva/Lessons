using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonConvertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Json example");

            StreamReader sr = new StreamReader(@"list_obj.json");

            string jsonString = sr.ReadToEnd();
            
            JObject obj = JObject.Parse(jsonString);

            //var res = obj["entries"][0]["values"].ToObject<PersonSet>();           

            List<Person> listPersons = new List<Person> {
                new Person { FirstName = "f01", LastName = "l01" },
                new Person { FirstName = "f02", LastName = "l02" }
            };

            string str = JsonConvert.SerializeObject(listPersons);

            StreamWriter sw = new StreamWriter("list_obj2.json");
            sw.Write(str);
            sw.Close();

            Dictionary<string,Person> listPersons2 = new Dictionary<string,Person> {

                { "", new Person { FirstName = "f01", LastName = "l01" } },
                { "", new Person { FirstName = "f02", LastName = "l02" } }
            };
            
            string str2 = JsonConvert.SerializeObject(listPersons);

            StreamWriter sw2 = new StreamWriter("list_obj3.json");
            sw.Write(str2);
            sw.Close();
        }
    }
}
