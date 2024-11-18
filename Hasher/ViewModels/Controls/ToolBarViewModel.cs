using System;

using Xlfdll.Windows.Presentation;
using Xlfdll.Windows.Presentation.Dialogs;

namespace Hasher
{
    public class ToolBarViewModel : ViewModelBase
    {
        public ToolBarViewModel(MainViewModel mainViewModel)
        {
            this.MainViewModel = mainViewModel;
        }

        public MainViewModel MainViewModel { get; }

        public RelayCommand<Object> AboutCommand
            => new RelayCommand<Object>
            (
                delegate
                {
                    AboutWindow aboutWindow = new AboutWindow
                    (App.MainWindow, App.Metadata,
                    new ApplicationPackUri("/Images/Hasher.png"));

                    aboutWindow.ShowDialog();
                }
            );
    }
}