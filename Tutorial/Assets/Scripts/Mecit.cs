using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecit : MonoBehaviour
{
    public float publicVariable;
    private float privateVariable;

    private void Start()
    {
        privateVariable = 150;
    }
    void Update()
    {
        privateVariable += Time.deltaTime;
    }
}
