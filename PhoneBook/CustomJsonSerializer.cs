using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class CustomJsonSerializer<T> : ISerlializer<T> where T: IEnumerable
    {
        public void Deserialize(string json)
        {
            T obj = JsonConvert.DeserializeObject<T>(json);
            //foreach (var item in obj)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }

        public void Serialize(T data, IWriter writer)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            writer.WriteLine(json);
        }
    }
}
