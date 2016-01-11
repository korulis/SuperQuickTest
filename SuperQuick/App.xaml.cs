using System.Windows;
using System.Data.Entity;

namespace SuperQuick
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Database.SetInitializer(new SuperQuickInitializer());
        }
    }
}
