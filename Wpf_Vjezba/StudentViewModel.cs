using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Wpf_Vjezba
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student Student { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public StudentViewModel(Student student)
        {
            this.Student = student;
        }
        

        public string Ime
        {
            get
            {
                return Student.Ime;
            }
            set
            {
                Student.Ime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Ime)));
            }

        }

        public string Prezime
        {
            get
            {
                return Student.Prezime;
            }
            set
            {
                Student.Prezime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Prezime)));
            }

        }

        public int Godine
        {
            get
            {
                return Student.Godine;
            }
            set
            {
                
                if (value >= 10 && value <= 100)
                {
                    Student.Godine = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Godine)));
                }

            }

        }

        public bool Redovan
        {
            get
            {
                return Student.Redovan;
            }
            set
            {
                Student.Redovan = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Redovan)));
            }

        }
    }
}
