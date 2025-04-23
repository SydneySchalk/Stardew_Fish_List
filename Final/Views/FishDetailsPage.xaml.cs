using FinalProj.Models;

namespace FinalProj.Views
{
    public partial class FishDetailsPage : ContentPage
    {
        public FishDetailsPage(Fish selectedFish)
        {
            InitializeComponent();
            BindingContext = selectedFish;
        }
    }
}
