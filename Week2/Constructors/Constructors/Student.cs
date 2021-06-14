using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Student
    {
        private readonly string _firstName;

        private readonly string _lastName;

        private readonly int _iD;
        public Student(int iD, string lastName, string firstName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _iD = iD;
        }

        public void GetStudentDetails(Student student)
        {
            

        }
    }
}
