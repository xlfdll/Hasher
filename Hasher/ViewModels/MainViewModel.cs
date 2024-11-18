using System;

namespace Hasher
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.ToolBarViewModel = new ToolBarViewModel(this);
            this.ContextMenuViewModel = new ContextMenuViewModel(this);
        }

        public ToolBarViewModel ToolBarViewModel { get; }
        public ContextMenuViewModel ContextMenuViewModel { get; }

        private Boolean _isHashing;
        private Boolean _isScanning;
        private String _status;

        public Boolean IsHashing
        {
            get
            {
                return _isHashing;
            }
            set
            {
                this.SetField(ref _isHashing, value);

                OnPropertyChanged(nameof(this.IsBusy));
            }
        }
        public Boolean IsScanning
        {
            get
            {
                return _isScanning;
            }
            set
            {
                this.SetField(ref _isScanning, value);

                OnPropertyChanged(nameof(this.IsBusy));
            }
        }
        public String Status
        {
            get { return _status; }
            private set { this.SetField(ref _status, value); }
        }

        public Boolean IsBusy
            => this.IsHashing || this.IsScanning;

        public void UpdateStatus(String text)
        {
            this.Status = text;
        }
    }
}