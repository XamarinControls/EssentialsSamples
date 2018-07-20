using System;
using System.Collections.Generic;
using EssentialsSamples.ViewModels;
using Xamarin.Forms;

namespace EssentialsSamples.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
