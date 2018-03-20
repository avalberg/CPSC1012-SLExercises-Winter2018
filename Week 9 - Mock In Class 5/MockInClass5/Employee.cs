using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInClass5
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dob;

        public Employee(string firstname, string lastname, DateTime dob)
        {
            _firstName = firstname;
            _lastName = lastname;
            _dob = dob;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            var age = today.Year - _dob.Year;
            if (today.Month < _dob.Month || (today.Month == _dob.Month && today.Day < _dob.Day))
                age--;
            return age;
        }
    }
}
