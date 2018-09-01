using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Vjezba
{
    static class StudentService
    {
        public static Student GetStudent()
        {
            return new Student
            {
                Ime = "Milica",
                Prezime = "Krmpotić",
                Godine = 33,
                Redovan = false
            };
        }

    }
}
