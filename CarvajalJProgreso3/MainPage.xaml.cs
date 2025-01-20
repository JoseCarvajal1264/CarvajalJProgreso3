using CarvajalJProgreso3.Interfaces;
using System.Runtime.CompilerServices;

namespace CarvajalJProgreso3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly ICarvajalPais _carvajalPais;

        public MainPage (ICarvajalPais service)
        {
            InitializeComponent();
            _carvajalPais = service;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;
            var data = await _carvajalPais.Obtener();
            listviewPais.ItemsSource = data;
            loading.IsVisible = false;

        }
    }

}
