using System.Threading.Tasks;

using FileToolbox.Models;
using FileToolbox.Services;
using FileToolbox.Views;

namespace FileToolbox.ViewModels;

/// <summary>
/// Apertura dell'editor tema, condivisa tra desktop e Android tramite <see cref="DialogPresenter"/>.
/// </summary>
internal static class ThemeEditorHelper
{
    public static async Task<ColorTheme?> ShowAsync(ThemeEditorViewModel viewModel) =>
        await DialogPresenter.ShowAsync<ThemeEditorContent, ColorTheme?>(
            () => new ThemeEditorWindow(viewModel),
            () => new ThemeEditorContent(),
            viewModel);
}
