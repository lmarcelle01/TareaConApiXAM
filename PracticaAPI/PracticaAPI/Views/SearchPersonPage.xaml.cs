using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaAPI.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaAPI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPlacePage : ContentPage
    {
        public SearchPlacePage()
        {
            InitializeComponent();
            this.BindingContext = new SearchPlacePageWiewModel();
        }
    }
}