using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    public class StudentManager
    {
        public static List<Student> studentsList = new List<Student>()
        {
            new Student("Ohad","saadia",31,28,46,200),
            new Student("Eden","Levanon",47,24,400,23),
            new Student("Daniel","Dadd",100,21,776,350),
        };

        public delegate bool FilterDelegate(Student student);
        public delegate int SumDelegate(Student student);
        public delegate decimal GetDecimalPropDelegate(Student student);
        public void Add(Student student)
        {
            studentsList.Add(student);
        }
        public void Remove(Student student)
        {
            studentsList.Remove(student);
        }

        public List<Student> Filter(FilterDelegate filterDelegate)
        {
            List<Student> list = new List<Student>();

            foreach (var student in studentsList)
            {
                if (filterDelegate(student))
                {
                    list.Add(student);
                }
            }

            return list;
        }

        public bool Contain(FilterDelegate filterDelegate)
        {
            foreach (var student in studentsList)
            {
                if (filterDelegate(student))
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum (SumDelegate sumDelegate)
        {
            int sum = 0;
            foreach (var student in studentsList)
            {
                sum += sumDelegate(student);
            }
            return sum;
        }

        public decimal Average (GetDecimalPropDelegate getDecimalPropDelegate)
        {
            decimal sum = 0;
            foreach (var student in studentsList)
            {
                sum += getDecimalPropDelegate(student);
            }
            return sum / studentsList.Count;

        }
    }
}
