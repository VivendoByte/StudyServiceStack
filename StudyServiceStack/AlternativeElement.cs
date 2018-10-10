using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyServiceStack
{
    public class AlternativeElement
    {
        public int year { get; set; }

        public static implicit operator Element(AlternativeElement ae)
        {
            return new Element() { age = DateTime.Now.Year - ae.year };
        }
    }
}