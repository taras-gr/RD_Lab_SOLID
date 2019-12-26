using RD_University.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University.Data
{
    public class StudentDataProvider
    {
        public IEnumerable<Student> GetStudents()
        {

            yield return new Student(1)
            {
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1996, 3, 10)
            };
        }
    }
}
