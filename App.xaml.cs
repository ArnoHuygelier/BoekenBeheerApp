using System.Configuration;
using System.Data;
using System.Windows;
using BoekenBeheerApp.Stores;
using BoekenBeheerApp.ViewModel;

namespace BoekenBeheerApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    NavigationStore _navigationStore = new NavigationStore();
    protected override void OnStartup(StartupEventArgs e)
    {
        _navigationStore.CurrentViewModel = new vmMainWindow(_navigationStore);

        MainWindow = new MainWindow()
        {
            DataContext = new vmMain(_navigationStore),
        };
        MainWindow.Show();
    }
}

