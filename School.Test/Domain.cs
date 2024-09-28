using School.Domain.Aggregate;

namespace School.Test
{
    public class Domain
    {
        [Fact]
        public void AddChapterAndLesson()
        {
            var section = new Section("1", Guid.NewGuid());

            ICollection<Content> contents = [
                    new Content("1"),
                    new Content("2"),
                    new Content("3"),
                    new Content("4"),
                    new Content("5"),
                    new Content("6"),
                    new Content("7"),
                    new Content("8"),
                    new Content("9"),
                    new Content("10"),
                ];

            var chapter = new Chapter("Historia do brasil", 1,1,"1","HAHAHA",Guid.NewGuid(), 1, contents);
            var chapter2 = new Chapter("Historia de Portugal", 1,1,"1","HAHAHA",Guid.NewGuid(), 1, contents);

            var lesson = new Lesson(Guid.NewGuid(),new DateOnly(), new DateOnly(), DateTime.Now, DateTime.Now, DayOfWeek.Friday);
            var lesson2 = new Lesson(Guid.NewGuid(),new DateOnly(), new DateOnly(), DateTime.Now, DateTime.Now, DayOfWeek.Friday);
            var lesson3 = new Lesson(Guid.NewGuid(),new DateOnly(), new DateOnly(), DateTime.Now, DateTime.Now, DayOfWeek.Friday);

            section.AddLesson(lesson);
            section.AddLesson(lesson2);
            section.AddLesson(lesson3);
            section.AddChapter(chapter);
            section.AddChapter(chapter2);


            Assert.Contains(chapter, section.Chapters);
            Assert.Contains(chapter2, section.Chapters);
            Assert.Contains(lesson, section.Lessons);
            Assert.Contains(lesson2, section.Lessons);
            Assert.Contains(lesson3, section.Lessons);
        }

        public void AddSubject()
        {
            var subject = new Subject("Historia", "Hist");
        }
    }
}