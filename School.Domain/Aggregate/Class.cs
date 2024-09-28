using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Aggregate
{
    public class Class
    {
        public string Name { get; private set; }
        public Grade Grade { get; private set; }
        private Guid _gradeId;

        public Class(string name, Guid gradeId)
        {
            Name = name;
            _gradeId = gradeId;
        }
    }
}
