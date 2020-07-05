using System.Windows;

namespace Bees.UI
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Realistically would use something like AutoFac to resolve dependencies then inject the data context in.
            // No real need here though
            DataContext = new BeeViewModel();
        }
    }
}