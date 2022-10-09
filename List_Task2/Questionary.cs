using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace List_Task2
{
    [Serializable]
    public class Questionary/*:ISerializable*/
    {
       public string? Name { get; set; }
       public string? Surname { get; set; }
       public string ?Email { get; set; }
       public long? Phone { get; set; }
       public Questionary(string? name, string? surname, string? email, long? phone)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }
        public Questionary()
        {
            Name = null;
            Surname = null;
            Email = null;
            Phone = null;
        }
        public override string ToString()
        {
            return $"{Name}  {Surname}  {Email}  {Phone}";
        }

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    info.AddValue("Name", Name);
        //    info.AddValue("Surname", Surname);
        //    info.AddValue("Email", Email);
        //    info.AddValue("Pone",Convert.ToInt64(Phone));
        //}
    }
}
