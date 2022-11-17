using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Image countdown;
    public Text timerText;

    [SerializeField] private float currentTime;
    public float duration;
    void Start()
    {
        currentTime = duration;
    }
    void Update()
    {
        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            timerText.text = ((int)currentTime).ToString();
            countdown.fillAmount = currentTime / duration;
        }
    }
}
