using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.UI.Xaml.Controls.Layout;
using VillageStore.Common;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using VillageStore.Views;

namespace VillageStore.ViewModels
{
    public class CitizenDetailsViewModel : NotificationObject
    {
        public CitizenDetailsViewModel()
        {
            CitizenMenu = new ObservableCollection<CitizenMenuClass>();
            CitizenMenu.Add(new CitizenMenuClass("Add Citizen", "ms-appx:///Images/Female1.png",  "#FFA400", "#E78E00",new AddCitizen()));
            CitizenMenu.Add(new CitizenMenuClass("Search Citizen", "ms-appx:///Images/Male1.png", "#6DA4A3", "#4E7F7D",new SearchCitizen()));
            CitizenMenu.Add(new CitizenMenuClass("Browse Citizens", "ms-appx:///Images/user.png", "#A45378", "#883F64",new BrowseCitizens()));

        }

        private Orientation orientation = Orientation.Horizontal;

        public Orientation Orientation
        {
            get { return orientation; }
            set { orientation = value; RaisePropertyChanged("Orientation"); }
        }

        private MinimizedItemsOrientation minOrientation = MinimizedItemsOrientation.Right;

        public MinimizedItemsOrientation MinOrientation
        {
            get { return minOrientation; }
            set { minOrientation = value; RaisePropertyChanged("MinOrientation"); }
        }

        private ObservableCollection<CitizenMenuClass> _citizenMenu;

        public ObservableCollection<CitizenMenuClass> CitizenMenu
        {
            get { return _citizenMenu; }
            set { _citizenMenu = value; }
        }

       
        

    }

    public class CitizenMenuClass
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public string TileColor { get; set; }

        public string HeaderColor { get; set; }

        public Page OutputContent { get; set; }

        public CitizenMenuClass(string name, string image, string color, string headercolor, Page content)
        {
            Name = name;
            Image = image;
            TileColor = color;
            HeaderColor = headercolor;
            OutputContent = content;
        }
    }
}
