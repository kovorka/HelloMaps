using HelloMaps.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloMaps.ViewModels
{
    public class MainPageViewModel
    {
        public string PageTitle { get; set; }
        public ObservableCollection<Officer> OfficerList { get; set; }
    }
}
