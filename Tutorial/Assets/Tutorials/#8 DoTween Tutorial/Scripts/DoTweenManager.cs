using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenManager : MonoBehaviour
{
    public Vector3 endValue;
    public float duration;
    public void OnComplete()
    {
        Debug.Log(transform.DOFlip());
    }
}
