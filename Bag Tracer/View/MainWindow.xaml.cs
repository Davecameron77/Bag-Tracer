using Bag_Tracer.ViewModel;
using System.Windows;

namespace Bag_Tracer.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVm();
        }
    }
}
