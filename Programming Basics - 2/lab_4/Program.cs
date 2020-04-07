using System;
using System.Collections.Generic;

namespace lab_4
{
    abstract class Institution
    {
        public string name;
        public int year;
        public int staff;
        public int pupils;

        public Institution(int pupils, int year, int staff, string name)
        {
            this.name = name;
            this.year = year;
            this.staff = staff;
            this.pupils = pupils;
        }
    }

    class School : Institution
    {
        //public List<Group> groups = new List<Group>();
        //public void AddGroup(Group group)
        //{
        //    groups.Add(group);
        //}
        public School(string name, int pupils, int year, int staff) : base(pupils, year, staff, name) { }
    }

    class Group : Institution
    {
        public Group(string name, int pupils, int year, int staff) : base(pupils, year, staff, name) { }
    }

    class University : Institution
    {
        public List<Faculty> faculties = new List<Faculty>();

        public void AddFaculty(Faculty group)
        {
            faculties.Add(group);
        }

        public University(string name, int students, int year, int staff) : base(students, year, staff, name) { }
    }

    class Faculty : Institution
    {
        public Faculty(string name, int students, int year, int staff) : base(students, year, staff, name) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var institutions = new List<Institution>();
            institutions.Add(new School("Chernihivskya ZNZ", 522, 1996, 34));

            var univ = new University("KPI", 1433, 1956, 54);
            univ.AddFaculty(new Faculty("FIVT", 100, 1958, 12));
            univ.AddFaculty(new Faculty("IPSA", 80, 1959, 10));
            univ.AddFaculty(new Faculty("TEF", 80, 1259, 10));

            institutions.Add(univ);

            foreach (var ins in institutions)
            {
                if (ins.GetType() == typeof(University))
                {
                    Console.WriteLine(((University)ins).faculties.Count);
                }
            }
        }
    }
}
