using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BarRotate : MonoBehaviour
{
    float _rotateSpeed = 40f;
    bool _rotatingTowardPlayer = true;
   

    
    void Update()
    {
        // Get the angle in degrees on the y axis, convert it to an integer to avoid precision loss.
        int currentRotation = (int)transform.eulerAngles.y;

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
        if (_rotatingTowardPlayer && currentRotation < 90f)
        {
            transform.Rotate(0, _rotateSpeed * Time.deltaTime, 0);
        }
        else if (!_rotatingTowardPlayer && currentRotation > 0f)
        {
            transform.Rotate(0, -_rotateSpeed * Time.deltaTime, 0);
        }

        // Clamp y rotation values to 0 and 90.
        float clampedYRotation = Mathf.Clamp(transform.eulerAngles.y, 0, 90);

        // Assign the clamped rotation value to the euler angles to prevent overshoot.
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, clampedYRotation, transform.eulerAngles.z);
    }
}
