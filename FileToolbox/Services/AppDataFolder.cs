using System;
using System.IO;

namespace FileToolbox.Services;

/// <summary>
/// Cartella dati dell'app (settings, profili, journal, temi, watch rules, plugin) sotto
/// <c>ApplicationData</c>. Usata da tutti gli store al posto di un path duplicato.
/// </summary>
public static class AppDataFolder
{
    private const string LegacyName = "Sbroglione";
    private const string Name = "FileToolbox";

    /// <summary>
    /// Cartella corrente. Al primo accesso sposta la vecchia cartella <c>Sbroglione</c> (nome
    /// precedente al rename) in <c>FileToolbox</c>, così impostazioni e plugin installati non vanno
    /// persi. Non tocca nulla se la nuova cartella esiste già; se lo spostamento fallisce l'app
    /// parte comunque con la cartella nuova vuota.
    /// </summary>
    public static string Root { get; } = ResolveRoot();

    private static string ResolveRoot()
    {
        string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string root = Path.Combine(appData, Name);
        string legacy = Path.Combine(appData, LegacyName);

        if (Directory.Exists(legacy) && !Directory.Exists(root))
        {
            try
            {
                Directory.Move(legacy, root);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
            }
        }

        return root;
    }
}
