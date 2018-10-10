using ServiceStack.Text;
using System.Collections.Generic;
using System.IO;

namespace StudyServiceStack
{
    public class Option3Reader : IReader
    {
        public string Provider => "Service Stack";

        public List<Element> GetAllFromFile(string source)
        {
            List<Element> result = null;

            if (!File.Exists(source))
            {
                return result;
            }

            using (TextReader reader = new StreamReader(source))
            {
                result = JsonSerializer.DeserializeFromReader<List<Element>>(reader);
            }
            

            return result;
        }

        public List<Element> GetAllFromJson(string source)
        {
            List<Element> result = null;

            result = JsonSerializer.DeserializeFromString<List<Element>>(source);

            return result;
        }
    }
}