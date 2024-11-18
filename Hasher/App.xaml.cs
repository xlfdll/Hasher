using System.Windows;

using Xlfdll.Diagnostics;

namespace Hasher
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static AssemblyMetadata Metadata => AssemblyMetadata.EntryAssemblyMetadata;
        public static new MainWindow MainWindow => App.Current.MainWindow as MainWindow;
    }
}