using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Aggregate
{
    public class Subject
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Code { get; private set; }
        public Class Class { get; private set; }
        private Guid _classId;
        public IReadOnlyCollection<Section> Sections { get; private set; }
        public Subject(string name, string code, Guid classId)
        {
            Name = name;
            Code = code;
            _classId = classId;
        }
    }
}
