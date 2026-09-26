using Avalonia.Controls;
using FileToolbox.Services;
using FileToolbox.ViewModels;

namespace FileToolbox.Views;

/// <summary>
/// Host desktop dell'editor tema. Il corpo vive in <see cref="ThemeEditorContent"/>,
/// condiviso con l'host overlay single-view.
/// </summary>
public partial class ThemeEditorWindow : Window
{
    // Costruttore senza parametri richiesto dal designer Avalonia (e dal loader XAML runtime).
    public ThemeEditorWindow()
        : this(new ThemeEditorViewModel(BuiltInThemes.ForVariant("Light")) { LivePreview = false })
    {
    }

    public ThemeEditorWindow(ThemeEditorViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        DialogContent.Completed += result => Close(result);
    }
}
