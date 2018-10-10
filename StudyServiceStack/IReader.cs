using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyServiceStack
{
    public interface IReader
    {
        string Provider { get; }
        List<Element> GetAllFromFile(string source);
        List<Element> GetAllFromJson(string source);
    }
}