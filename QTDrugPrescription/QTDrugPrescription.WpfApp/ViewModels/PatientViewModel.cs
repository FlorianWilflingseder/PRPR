using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QTDrugPrescription.WpfApp.ViewModels
{
    public class PatientViewModel : BaseViewModel
    {
        Logic.Controllers.PatientController ctrl = new Logic.Controllers.PatientController();
        public string SocialSecurityNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

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
        public void Create()
        {
          

            try
            {
                var patient = new Logic.Entities.Patient { FirstName = this.FirstName, LastName = this.LastName, SocialSecurityNumber = this.SocialSecurityNumber };
                Task.Run(async () => {
                    await ctrl.InsertAsync(patient);
                    await ctrl.SaveChangesAsync();
                    SocialSecurityNumber = string.Empty;
                    FirstName = string.Empty;   
                    LastName = string.Empty;    
                    OnPropertyChanged(nameof(SocialSecurityNumber));
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(LastName));    
                }).Wait();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
