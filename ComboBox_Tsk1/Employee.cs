using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox_Tsk1
{
    public  class Employee
    {
        public string? Surname { get; set; }
        public string? City { get; set; }
        public double ? Salary { get; set; }
        public string ? Position { get; set; }
        public string ? Street { get; set; }
        public int? NumbereHouse { get; set; }
        public void IniEmployee(string? surname, string? city, double? salary, string? position, string? street, int? numbereHouse)
        {
            Surname = surname;
            City = city;
            Salary = salary;
            Position = position;
            Street = street;
            NumbereHouse = numbereHouse;
        }
        public Employee()
        {
            Surname = null;
            City = null;
            Salary = null;
            Position = null;
            Street = null;
            NumbereHouse = null;
        }
        public override string ToString()
        {
            return $"{Surname},  {City},  {Salary}  ,  {Convert.ToString(Salary)}," +
                $" {Position},  {Street},  {NumbereHouse.ToString()}";
        }
    }
}
