using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrimeraAplicacion.ViewModels
{
    public class SurveyDetailsViewModel: NotificationObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string favoritefood;

        public string FavoriteFood
        {
            get { return favoritefood; }
            set { favoritefood = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }

        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(() => 
            { 
                
            });
        }
    }
}
