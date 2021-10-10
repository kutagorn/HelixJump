using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  public Rigidbody rb;
  public float jumpForce;
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        rb.AddForce(Vector3.up * jumpForce);
    }
}
