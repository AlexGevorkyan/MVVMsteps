using MVVMsteps.Commands;
using MVVMsteps.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace MVVMsteps.ViewModel
{
    public class WindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        Contact contact = new Contact { FirstName = "Clifford", LastName = "Simak", PhoneNumber = "111" };
        public string LastName
        {
            get { return contact.LastName; }
            set { 
                contact.LastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        //public string LastName { set; get; }

        //string lastName;
        //public string LastName
        //{
        //    get { return lastName; }
        //    set
        //    {
        //        lastName = value;
        //        OnPropertyChanged(nameof(LastName));
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;

        public WindowViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName);
            Contacts = new ObservableCollection<Contact>();
        }

        private void OnChangeName(object commandParameter)
        {
            LastName = commandParameter.ToString();
            Contacts.Add(new Contact { LastName = LastName, FirstName = "", PhoneNumber = "" });
        }



    }
}
