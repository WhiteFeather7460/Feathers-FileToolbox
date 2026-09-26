using Avalonia.Controls;
using FileToolbox.ViewModels;

namespace FileToolbox.Views;

public partial class ComparisonView : UserControl
{
    public ComparisonView()
    {
        InitializeComponent();
        DataContext = new ComparisonViewModel();
    }
}
