using System;
using UnityEditor;
using UnityEditor.Build.Reporting;

public static class MotoropolisWebGLBuild
{
    private const string OutputPath = "Builds/WebGL";

    public static void Build()
    {
        var options = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/MainScene.unity" },
            locationPathName = OutputPath,
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(options);
        if (report.summary.result != BuildResult.Succeeded)
        {
            throw new Exception($"WebGL build failed: {report.summary.result}");
        }

        Console.WriteLine($"WebGL build completed at {OutputPath}.");
    }
}
