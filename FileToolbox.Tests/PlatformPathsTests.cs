using System;
using FileToolbox.Services;
using Xunit;

namespace FileToolbox.Tests;

public class PlatformPathsTests
{
    public PlatformPathsTests() => PlatformPaths.DefaultRootPathOverride = null;

    [Fact]
    public void DefaultRootPath_WithoutOverride_ReturnsUserProfile()
    {
        Assert.Equal(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            PlatformPaths.DefaultRootPath);
    }

    [Fact]
    public void DefaultRootPath_WithOverride_ReturnsOverrideValue()
    {
        PlatformPaths.DefaultRootPathOverride = () => "/storage/emulated/0";

        Assert.Equal("/storage/emulated/0", PlatformPaths.DefaultRootPath);

        PlatformPaths.DefaultRootPathOverride = null;
    }
}
