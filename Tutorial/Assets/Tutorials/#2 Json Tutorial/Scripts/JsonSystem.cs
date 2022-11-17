using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class JsonSystem : MonoBehaviour
{
    public InputField idText;
    public InputField nameText;
    public InputField surNameText;
   

    public void SaveToJson()
    {
        MyData myData = new MyData();

        myData.id = idText.text;
        myData.name = nameText.text;
        myData.surName = surNameText.text;

        string json = JsonUtility.ToJson(myData, true);
        File.WriteAllText(Application.dataPath + "/MyData.json", json);
    }


    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/MyData.json");
        MyData myData = JsonUtility.FromJson<MyData>(json);

        idText.text = myData.id;
        nameText.text = myData.name;
        surNameText.text = myData.surName;
    }
}
