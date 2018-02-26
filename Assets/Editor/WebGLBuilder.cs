﻿using UnityEditor;

public class WebGLBuilder
{
    public static void Build()
    {
        string[] scenes = {
            "Assets/Scenes/Playground.unity",
        };

        string outputPath = "Build/";

        BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.WebGL, BuildOptions.None);
    }
}
