using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{
    string username;
    public InputField usernameInput;

    public void SetUsernameFromInput(string input)
    {
        username = input;
    }

    public void SetUsername()
    {
        PlayerPrefs.SetString("Username", username);
        Debug.Log("Username Saved Successfully");
    }

    public void GetUsername()
    {
        username = PlayerPrefs.GetString("Username");
        usernameInput.text = username;
        Debug.Log("Username Loaded Successfully");
    }
}
