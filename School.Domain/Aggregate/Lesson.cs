using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Aggregate
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public User User { get; set; }
        private Guid _userId;
        public Section Section { get; set; }
        public Lesson(Guid userId, DateOnly startDate, DateOnly endDate, DateTime startTime, DateTime endTime, DayOfWeek dayOfWeek)
        {
            _userId = userId;
            StartDate = startDate;
            EndDate = endDate;
            StartTime = startTime;
            EndTime = endTime;
            DayOfWeek = dayOfWeek;
        }
    }
}
