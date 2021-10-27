using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    public class Filters
    {
        public bool GradeUnder50(Student student)
        {
            if (student.Grade < 50) return true;
            else return false;
        }

        public bool FirstNameFirstLetterMatchLastNameFirstLetter(Student student)
        {
            if (student.FirstName[0] == student.LastName[0]) return true;
            else return false;
        }

    }
}
