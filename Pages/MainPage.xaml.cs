using BlazorApp.Models;
using BlazorApp.PageModels;

namespace BlazorApp.Pages
{
    public partial class MainPage : ContentPage
    {
        private int count;


        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}