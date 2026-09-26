using Avalonia.Controls;
using FileToolbox.ViewModels;

namespace FileToolbox.Views;

public partial class DuplicatesView : UserControl
{
    public DuplicatesView()
    {
        InitializeComponent();
        DataContext = new DuplicatesViewModel();
    }
}
