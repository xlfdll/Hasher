using System;
using System.Windows;
using System.Windows.Controls;

using Xlfdll.Windows.Presentation;

namespace Hasher
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_PreviewDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                e.Handled = true; // Only stop handling after a file drop
            }
        }

        private void MainWindow_Drop(object sender, DragEventArgs e)
        {
            String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (files != null && files.Length > 0)
            {
                MainViewModel mainViewModel = this.DataContext as MainViewModel;


            }
        }

        private void FileHashListView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!FileHashListView.HasItems)
            {
                GridView gridView = FileHashListView.View as GridView;

                if (gridView != null)
                {
                    gridView.UniformColumnWidth(FileHashListView.ActualWidth);
                }
            }
        }
    }
}