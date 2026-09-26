using System.Threading.Tasks;

using FileToolbox.Models;
using FileToolbox.Services;
using FileToolbox.Views;

namespace FileToolbox.ViewModels;

/// <summary>
/// Apertura dell'editor profilo, condivisa tra desktop e Android tramite
/// <see cref="DialogPresenter"/>.
/// </summary>
internal static class ProfileEditorHelper
{
    public static async Task<bool> ShowAsync(ConnectionProfile profile, ICredentialStore credentialStore)
    {
        var viewModel = new ProfileEditorViewModel(profile, credentialStore);

        return await DialogPresenter.ShowAsync<ProfileEditorContent, bool>(
            () => new ProfileEditorWindow(viewModel),
            () => new ProfileEditorContent(),
            viewModel);
    }
}
