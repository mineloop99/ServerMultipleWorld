using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;
public class AssetBundleDown : MonoBehaviour
{
    public string url; 
    public string savePath;
    void Start()
    {
        StartCoroutine(GetAssetBundle());
    }

    IEnumerator GetAssetBundle()
    {
        WWW www = new WWW(url);
        yield return www;
        string file = www.text;
        File.WriteAllText(savePath, file);
    }
}
