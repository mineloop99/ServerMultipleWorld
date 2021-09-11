using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AssetBundleLoad : MonoBehaviour
{
    AssetBundle myLoadedAssetBundle;
    public string path;
    public string assetBundleName;
    void Start()
    {
        LoadAssetBundle(path);
        InstantiateObjectFromBundle(assetBundleName);
    }
    void LoadAssetBundle(string _bundleUrl)
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile(_bundleUrl);
        Debug.Log(myLoadedAssetBundle == null ? "Failed Loaded AssetBundle" : "Loaded AssetBundle Sussesfully");

    }
    private void InstantiateObjectFromBundle(string _assetBunleName)
    {
        var prefab = myLoadedAssetBundle.LoadAsset(_assetBunleName);
        Instantiate(prefab);
    }
}
