using FinalProj.Views;

namespace FinalProj
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(FishDetailsPage), typeof(FishDetailsPage));
        }
    }
}
