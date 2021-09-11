#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetBundleBuild : Editor
{
    [MenuItem ("Assets/ Build Asset Bundle")]
    static void BuildBundle()
    {
        BuildPipeline.BuildAssetBundles(@"C:\Users\Admin\Desktop\Games\Bundle", 
                                        BuildAssetBundleOptions.None, 
                                        BuildTarget.StandaloneWindows64);
    }
}
#endif