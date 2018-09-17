using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLearning
{
    public class EditorAttribute : Attribute
    {
        public Type type;
        public EditorAttribute(Type t)
        {
            type = t;
        }
    }
}
