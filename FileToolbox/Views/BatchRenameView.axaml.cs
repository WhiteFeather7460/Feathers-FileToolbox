using Avalonia.Controls;
using FileToolbox.ViewModels;

namespace FileToolbox.Views;

public partial class BatchRenameView : UserControl
{
    public BatchRenameView()
    {
        InitializeComponent();
        DataContext = new BatchRenameViewModel();
    }
}
