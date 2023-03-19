using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenEditorManager : MonoBehaviour
{
    public Transform obj;

    public void JumpObj(Vector3 endValue, float jumpPower, int numJumps, float duration)
    {
        Debug.Log("object jumped");
        obj.DOJump(endValue, jumpPower, numJumps, duration);
    }
}
