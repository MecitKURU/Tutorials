using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FloatingJoystick joystick;
    public float movementSpeed, rotationSpeed;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        transform.position += direction * Time.deltaTime * movementSpeed;
        transform.forward += direction * Time.deltaTime * rotationSpeed;
    }
}
