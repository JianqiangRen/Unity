using UnityEditor;

public class CreateAssetBundles
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllABs()
    {
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneOSXUniversal);
    }

    [MenuItem("Assets/Build Asset Bundles Using BuildMap")]
    static void BuildMapABs()
    {
        // Create the array of bundle build details.
        AssetBundleBuild[] buildMap = new AssetBundleBuild[1];

        buildMap[0].assetBundleName = "enemybundle";

        string[] enemyAssets = new string[2];
        enemyAssets[0] = "Assets/Prefab/Cube.prefab";
        enemyAssets[1] = "Assets/Prefab/Sphere.prefab";

        buildMap[0].assetNames = enemyAssets;

        BuildPipeline.BuildAssetBundles("Assets/AssetBundles", buildMap, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }

}