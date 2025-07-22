using System.Collections.ObjectModel;
using System.Windows;
using Telerik.Windows.Controls;

namespace WpfApplication;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        StyleManager.ApplicationTheme = new Windows11Theme();
        InitializeComponent();

        var source = new ObservableCollection<RowInfo>();
        for (int i = 0; i < 100; i++)
        {
            source.Add(new RowInfo() { Id = i, Name = $"Record {i}" });
        }
        DataContext = source;
    }
}
