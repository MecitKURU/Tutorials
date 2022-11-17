using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.IO;
public class ImageDownloadWithUrl : MonoBehaviour
{
    public string fileName, url;
    public Image image;
   

    private void WriteImageOnDisk()
    {
        byte[] textureBytes = image.sprite.texture.EncodeToPNG();
        File.WriteAllBytes(Application.persistentDataPath + "/" + fileName + ".png", textureBytes);

        Debug.Log(Application.persistentDataPath);
        Debug.Log("File Written On Disk");
    }

    IEnumerator GetImageFromWeb()
    {
        UnityWebRequest reg = UnityWebRequestTexture.GetTexture(url);
        yield return reg.SendWebRequest();

        if(reg.isNetworkError || reg.isHttpError)
        {
            Debug.Log(reg.error);
        }

        else
        {
            Texture2D img = ((DownloadHandlerTexture)reg.downloadHandler).texture;
            image.sprite = Sprite.Create(img, new Rect(0, 0, 1080, 1920), Vector2.zero);
            WriteImageOnDisk();
        }
    }

    public void GetImageFromURL()
    {
        StartCoroutine(GetImageFromWeb());
    }
}
