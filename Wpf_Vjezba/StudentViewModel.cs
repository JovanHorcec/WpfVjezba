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
        private Student student;

        public event PropertyChangedEventHandler PropertyChanged;

        public StudentViewModel(Student student)
        {
            this.student = student;
        }
        

        public string Ime
        {
            get
            {
                return student.Ime;
            }
            set
            {
                student.Ime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Ime)));
            }

        }

        public string Prezime
        {
            get
            {
                return student.Prezime;
            }
            set
            {
                student.Prezime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Prezime)));
            }

        }

        public int Godine
        {
            get
            {
                return student.Godine;
            }
            set
            {
                student.Godine = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Godine)));
            }

        }

        public bool Redovan
        {
            get
            {
                return student.Redovan;
            }
            set
            {
                student.Redovan = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Redovan)));
            }

        }
    }
}
