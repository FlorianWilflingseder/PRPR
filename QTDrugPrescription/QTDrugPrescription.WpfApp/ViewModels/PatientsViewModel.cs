using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QTDrugPrescription.WpfApp.ViewModels
{
    public class PatientsViewModel : BaseViewModel
    {
        Logic.Controllers.PatientController ctrl = new Logic.Controllers.PatientController();
        public ObservableCollection<Logic.Entities.Patient> Students
        {
            get
            {
                var models = Task.Run(async () => await ctrl.GetAllAsync()).Result;

                models = models == null ? Array.Empty<Logic.Entities.Patient>() : models;

                return new ObservableCollection<Logic.Entities.Patient>(models);
            }
     
        }
        public int DataItemWidth { get; set; } = 200;

        private ICommand? commandAdd;

        public ICommand CommandAdd
        {
            get
            {
                 return RelayCommand.CreateCommand(ref commandAdd, p =>
                {
                    Create(); //Kommando für den Button
                },
              p => true); //Bedingung für den Button aktiv/deaktiv }
            }
        }


        private ICommand? commandDelete;

        public ICommand CommandDelete
        {
            get
            {
                return RelayCommand.CreateCommand(ref commandDelete, p =>
                {
                    Delete(Convert.ToInt32(p)); //Kommando für den Button
                },
                p => true); //Bedingung für den Button aktiv/deaktiv
            }
        }

        public void Delete(int id)
        {
            string caption = "Patient";
            string messageBoxText = "Are you sure you want to delete this?";

                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Stop;

            var result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            if(result == MessageBoxResult.Yes)
            {
                Task.Run(async () => {
                    await ctrl.DeleteAsync(id);
                    await ctrl.SaveChangesAsync();
                }).Wait();
                OnPropertyChanged(nameof(Students));
            }
           
        }

        public void Create()
        {
            var addWindow = new AddWindow();

            addWindow.ShowDialog();



            OnPropertyChanged(nameof(Students));
        }


        public Visibility DeleteVisible => commandDelete != null ? commandDelete.CanExecute(null) ? Visibility.Visible : Visibility.Hidden : Visibility.Hidden;

    }
}
