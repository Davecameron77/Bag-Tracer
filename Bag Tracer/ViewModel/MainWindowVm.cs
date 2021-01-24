using Bag_Tracer.View.Fragments;
using Bag_Tracer.ViewModel.Helpers;
using System.Collections.ObjectModel;
using System.Linq;

namespace Bag_Tracer.ViewModel
{
    internal class MainWindowVm
    {
        #region Constructors

        internal MainWindowVm()
        {
            MainWindowTabs = new ObservableCollection<CloseableTab>();

            NewTabCommand = new RelayCommand(AddPage);
            InitialLoad();
        }

        #endregion

        #region Properties

        public RelayCommand NewTabCommand { get; set; }

        public ObservableCollection<CloseableTab> MainWindowTabs { get; set; }
        public CloseableTab ActiveTab { get; set; }

        #endregion

        #region Methods

        private void AddPage(object parameter)
        {
            System.Diagnostics.Debug.WriteLine("Called");
            MainWindowTabs.Add(new CloseableTab());
        }

        private void InitialLoad()
        {
            if (MainWindowTabs.Count == 0)
            {
                AddPage(null);
                ActiveTab = MainWindowTabs.LastOrDefault();
            }
        }

        #endregion
    }
}
