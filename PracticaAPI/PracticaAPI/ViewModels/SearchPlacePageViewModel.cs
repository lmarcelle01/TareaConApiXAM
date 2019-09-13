using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PracticaAPI.Models;
using PracticaAPI.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PracticaAPI.ViewModels
{
    class SearchPlacePageWiewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        IApiService ApiService = new ApiService();

        public ICommand GetPersonCommand { get; set; }

        public Candidate Candidate{ get; set; }


        public SearchPlacePageWiewModel()
        {
            Candidate = new Candidate();
            GetPersonCommand = new Command(async () =>
            {
                await GetPlace();
            });

        }

        async Task GetPlace()
        {
            try
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    var place = await ApiService.GetLocation(Candidate.Name);
                    if(place.Candidates.Count == 0)
                        await App.Current.MainPage.DisplayAlert("Error", "No se encontró información sobre el lugar especificado.", "Ok");
                    else
                    {
                        Candidate.Rating = place.Candidates[0].Rating;
                        Candidate.formatted_address = place.Candidates[0].formatted_address;
                    }

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "No tienes conección a internet", "Ok");
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", "No se pudo conectar con el Servidor", "Ok");
            }
        }

    }


}

