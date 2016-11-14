using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class JSONSerializer<T> : ISerializer<T> where T: IEnumerable
    {
        public string Serialize(T data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            return json;
        }

        public T Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
