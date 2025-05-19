using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusanRestaurantApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BusanRestaurantApp.ViewModels
{
    public class GoogleMapViewModel : ObservableObject
    {
        private string _matjbLocation = "";
        private BusanItem _selectedMatjbItem;

        public BusanItem SelectedMatjbItem
        {
            get => _selectedMatjbItem;
            set
            {
                if (SetProperty(ref _selectedMatjbItem, value) && value != null)
                {
                    // 아이템이 설정될 때만 한 번 URL을 갱신
                    MatjbLocation = $"https://www.google.com/maps/place/{value.Lat},{value.Lng}";
                }
            }
        }

        public string MatjbLocation
        {
            get => _matjbLocation;
            private set => SetProperty(ref _matjbLocation, value);
        }
    }
}