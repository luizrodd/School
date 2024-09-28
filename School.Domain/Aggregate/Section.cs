using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Aggregate
{
    public class Section
    {
        public Section(string nome, Guid subjectId)
        {
            Nome = nome;
            _subjectId = subjectId;
        }

        public string Nome { get; set; }
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public Subject Subject { get; set; }
        private Guid _subjectId;

        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }

        public void AddChapter(Chapter chapter)
        {
            Chapters.Add(chapter);
        }
    }
}
