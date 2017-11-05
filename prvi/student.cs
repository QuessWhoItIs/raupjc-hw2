using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvi
{
    public class Student
    {
        public string Name { get; set; }
        public string Jmbag { get; set; }
        public Gender Gender { get; set; }
        public Student(string name, string jmbag)
        {
            Name = name;
            Jmbag = jmbag;
        }
        public override bool Equals(object obj)
        {
            return this.Jmbag == (obj as Student)?.Jmbag;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }
        public override int GetHashCode()
        {
            return Jmbag.GetHashCode();
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }
    }
    public enum Gender
    {
        Male, Female
    }
}
