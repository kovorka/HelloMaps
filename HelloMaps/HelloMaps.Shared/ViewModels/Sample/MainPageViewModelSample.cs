using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using HelloMaps.Entities;


namespace HelloMaps.ViewModels.Sample
{
    public class MainPageViewModelSample
    {
        public MainPageViewModel ViewModel { get; set; }

        public MainPageViewModelSample()
        {
            ViewModel = new MainPageViewModel
            {
                PageTitle = "Officer DataSet",
                OfficerList = new ObservableCollection<Officer>(new Data.DataService().GetOfficersBySuburb(null))
            };
        }
    }
}
