using RD_University_SRP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RD_University.Interface
{
    public interface IStudentDataProvider<T>
    {
        IEnumerable<T> GetStudents();
    }
}
