using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Aggregate
{
    public class Content
    {
        public string Name { get; private set; }

        public Content(string name)
        {
            Name = name;
        }

    }
}
