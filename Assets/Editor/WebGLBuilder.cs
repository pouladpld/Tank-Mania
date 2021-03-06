﻿using UnityEditor;

public class WebGLBuilder
{
    public static void Build()
    {
        string[] scenes = {
            "Assets/Scenes/Main Menu.unity",
            "Assets/Scenes/Level 1.unity",
            "Assets/Scenes/Level 2.unity",
            "Assets/Scenes/Level 3.unity",
            "Assets/Scenes/Score Sheet.unity",
        };

        string outputPath = "Build";

        BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.WebGL, BuildOptions.None);
    }
}
