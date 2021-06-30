﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        public Guid Guid { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public static int STUDENT_COUNTER;

        static Student()
        {
            STUDENT_COUNTER = 0;
        }

        public Student()
        {
            STUDENT_COUNTER += 1;
            Guid = Guid.NewGuid();
        }

        public Student(int studentId, string name, string surname, int age) : this()
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;

        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public override int GetHashCode()
        {
            var hashCode = -1235398547;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }
    }
}
