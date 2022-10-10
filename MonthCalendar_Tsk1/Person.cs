using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthCalendar_Tsk1
{
    internal class Person
    {
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public DateTime? Date { get; set; }
        public string? Surname { get; set; }
        public string? Point { get; set; }
        public string? Other { get; set; }
        public string? Status { get; set; }

        public Person(string? name, string? secondName, DateTime? date, string? surname, string? point, string? other, string? status)
        {
            Name = name;
            SecondName = secondName;
            Date = date;
            Surname = surname;
            Point = point;
            Other = other;
            Status = status;
        }
        public Person()
        {
            Name = null;
            SecondName = null;
            Date = null;
            Surname = null;
            Point = null;
            Other = null;
            Status = null;
        }
    }
}
