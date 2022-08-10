using PrimeraAplicacion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrimeraAplicacion.ViewModels
{
    public class MainPageViewModel: NotificationObject
    {

        private ObservableCollection<Survey> survays;

        public ObservableCollection<Survey> Survays
        {
            get { return survays; }
            set 
            { 
                survays = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }

        public MainPageViewModel()
        {
            Survays = new ObservableCollection<Survey>();
            AddCommand = new Command(AddCommandExecute);

            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", (a, s) =>
            {
                Survays.Add(s);
            });
        }

        private void AddCommandExecute()
        {
            MessagingCenter.Send(this, "AddSurvey");
        }
    }
}
