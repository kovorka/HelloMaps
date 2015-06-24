using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HelloMaps.Data;
using HelloMaps.Entities;
using Windows.Devices.Geolocation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloMaps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var service = new DataService();
            ObservableCollection<Officer> officerList = new ObservableCollection<Officer>(service.GetOfficersBySuburb(null));
            this.DataContext = new ViewModels.MainPageViewModel
            {
                PageTitle = "This is the page title!",
                OfficerList = officerList
            };

            var location = new Bing.Maps.Location
            {
                Latitude = -31.954527,
                Longitude = 115.855602
            };
            MyMap.SetView(location, 15);
        }
    }
}
