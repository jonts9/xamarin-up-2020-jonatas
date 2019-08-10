using Cross2020.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Cross2020
{
    public sealed class MainViewModel : BindableObject
    {
        private ObservableCollection<Candy> items = new ObservableCollection<Candy>();

        public ObservableCollection<Candy> Items
        {
            get => items;
            set
            {
                items = value; OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Items = new ObservableCollection<Candy>(
                new List<Candy> {
                    new Candy{Name = "asd" , Description = "desc"}
                });
        }

    }
}
