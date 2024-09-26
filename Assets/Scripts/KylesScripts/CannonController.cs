using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject cannonBallPrefab;
    float shotInterval = 5.0f;
    float lastShotTime;
    void Start()
    {
        // Initialize the last shot time to game time.
        lastShotTime = Time.time;
    }

    
    void Update()
    {
        if (Time.time - lastShotTime >= shotInterval)
        {
            Instantiate(cannonBallPrefab);
            // Reset shot time.
            lastShotTime = Time.time;
        }
    }
}
