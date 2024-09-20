using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarRotate : MonoBehaviour
{
    float _rotateSpeed = 40f;
    bool _rotatingTowardPlayer = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        // Get the angle in degrees on the y axis.
        float currentRotation = transform.eulerAngles.y;

        // Switch the direction based current rotation. 
        if (currentRotation >= 90f)
        {
            _rotatingTowardPlayer = false;
        }
        else if (currentRotation <= 0f)
        {
            _rotatingTowardPlayer = true;
        }

        // Rotate based on the direction.
        if (_rotatingTowardPlayer)
        {
            transform.Rotate(0, _rotateSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, -_rotateSpeed * Time.deltaTime, 0);
        }
    }
}
