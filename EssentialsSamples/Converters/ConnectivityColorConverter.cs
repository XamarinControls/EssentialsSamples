using System;

using Xamarin.Forms;

namespace EssentialsSamples.Converters
{
    public class ConnectivityColorConverter : ContentPage
    {
        public ConnectivityColorConverter()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

