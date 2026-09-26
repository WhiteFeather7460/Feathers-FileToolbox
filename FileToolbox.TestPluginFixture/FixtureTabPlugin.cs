using Avalonia.Controls;
using FileToolbox.PluginContracts;

namespace FileToolbox.TestPluginFixture;

/// <summary>Plugin minimo usato solo dai test di <c>PluginLoader</c> (FileToolbox.Tests).</summary>
public sealed class FixtureTabPlugin : ITabPlugin
{
    public static int UnloadCallCount;

    public string Id => "fixture-plugin";
    public string Header => "Fixture";
    public string IconGlyph => "fa-solid fa-flask";

    public Control CreateView() => new TextBlock { Text = "fixture plugin view" };

    public void OnUnload() => UnloadCallCount++;
}
