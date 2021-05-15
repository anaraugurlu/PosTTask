using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNamespace
{
    public class Base
    {
        public Guid Id { get; set; }

        public override string ToString()
        {
            return $"Id{Id}";
        }

    }
}
