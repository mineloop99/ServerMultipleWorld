using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using UnityEngine;

public class AssetBundleDownload : MonoBehaviour
{
    WebClient webClient = new WebClient();
    public string savePath = "";
    public string url;
    void Start()
    {
        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
        Uri Uri = new Uri(url);
        webClient.DownloadFileAsync(Uri,savePath);
    }
    private void FileDownloadCompleted(object _sender, AsyncCompletedEventArgs e)
    {
        Debug.Log("DownLoad Completed");
    }
}
