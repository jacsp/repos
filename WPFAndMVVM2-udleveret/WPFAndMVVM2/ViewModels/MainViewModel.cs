using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // Very important that you make the list as a property (with get and set)!
        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }

        public PersonViewModel SelectedPerson { get; set; }

        public MainViewModel()
        {
            PersonsVM = new ObservableCollection<PersonViewModel>();

            foreach (var person in personRepo.GetAll())
            {
                PersonViewModel temp = new(person);

                PersonsVM.Add(temp);
            }
        }

        public void UpdateSelectedPerson()
        {
            OnPropertyChanged(nameof(SelectedPerson));
        }

        public void AddDefaultPerson()
        {
            Person newPerson = personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonViewModel pvm = new(newPerson);
            PersonsVM.Add(pvm);
            SelectedPerson = pvm;
            UpdateSelectedPerson();
        }

        public void DeleteSelectedPerson()
        {

            PersonsVM.Remove(SelectedPerson);
        }
    }
}
