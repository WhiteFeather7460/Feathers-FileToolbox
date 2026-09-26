using Avalonia.Controls;
using FileToolbox.ViewModels;

namespace FileToolbox.Views;

/// <summary>
/// Scheda "Esplora": navigazione del file system (in sviluppo).
/// </summary>
public partial class FileBrowserView : UserControl
{
    public FileBrowserView()
    {
        InitializeComponent();
        DataContext = new FileBrowserViewModel();
    }
}
