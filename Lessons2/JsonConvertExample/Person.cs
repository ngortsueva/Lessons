using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace JsonConvertExample
{
    public class PersonSet
    {
        public List<Person> Persons;
    }

    public class Person
    {
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }
    }
}
