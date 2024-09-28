using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Aggregate
{
    public class Chapter
    {
        public Chapter(string name, int module, int planLesson, string planWeek, 
            string skillsCovered, Guid subjectId, 
            int classId, ICollection<Content> contents)
        {
            Name = name;
            Module = module;
            PlanLesson = planLesson;
            PlanWeek = planWeek;
            SkillsCovered = skillsCovered;
            CreatedAt = DateTime.Now;
            _subjectId = subjectId;
            _classId = classId;
            Contents = contents;
        }
        public string Name { get; private set; }
        public int Module { get; private set; }
        public int PlanLesson { get; private set; }
        public string PlanWeek { get; private set; }
        public string SkillsCovered { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public Section Section { get; private set; }
        private int _sectionId;
        public Subject Subject { get; private set; }
        private Guid _subjectId;
        public Class Class { get; private set; }
        private int _classId;
        public ICollection<Content> Contents { get; private set; } = new List<Content>();
    }
}
