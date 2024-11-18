namespace Hasher
{
    public class ContextMenuViewModel : ViewModelBase
    {
        public ContextMenuViewModel(MainViewModel mainViewModel)
        {
            this.MainViewModel = mainViewModel;
        }

        public MainViewModel MainViewModel { get; }
    }
}