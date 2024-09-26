using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    float shotForce = 400f;
    float gravityScale = 5f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        rb.AddForce(shotForce * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(0, shotForce / gravityScale, 0);
    }
}
