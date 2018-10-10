using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace StudyServiceStack
{
    public class Option1Reader : IReader
    {
        Type type = typeof(List<Element>);
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Element>));

        public string Provider => "DataContractJsonSerializer";

        public List<Element> GetAllFromFile(string source)
        {
            List<Element> result = null;

            if (!File.Exists(source))
            {
                return result;
            }

            using (FileStream stream = new FileStream(source, FileMode.Open))
            {
                result = serializer.ReadObject(stream) as List<Element>;
            }

            return result;
        }

        public List<Element> GetAllFromJson(string source)
        {
            List<Element> result = null;

            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(source)))
            {
                result = (List<Element>)serializer.ReadObject(ms);
            }

            return result;
        }
    }
}