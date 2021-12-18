using MVVMsteps.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMsteps.ViewModel
{
    public class WindowViewModel : INotifyPropertyChanged
    {
        //Contact contact = new Contact { FirstName="Clifford", LastName="Simak", PhoneNumber="111"};
        //public string LastName 
        //{
        //    get { return contact.LastName; }
        //    set { contact.LastName = value;  }
        //}
        //public string LastName { set; get; }

        string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



    }
}
