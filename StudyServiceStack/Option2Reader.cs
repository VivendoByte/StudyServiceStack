using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyServiceStack
{
    public class Option2Reader : IReader
    {
        public string Provider => "Json.NET";

        public List<Element> GetAllFromFile(string source)
        {
            List<Element> result = null;

            if (!File.Exists(source))
            {
                return result;
            }

            Type type = typeof(List<Element>);
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(source))
            {
                result = (List<Element>)serializer.Deserialize(file, type);
            }

            return result;
        }

        public List<Element> GetAllFromJson(string source)
        {
            List<Element> result = null;

            result = JsonConvert.DeserializeObject<List<Element>>(source);

            return result;
        }
    }
}