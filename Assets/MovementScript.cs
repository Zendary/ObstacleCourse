using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 5.0f;
    Rigidbody rb;
    private bool moveRight = true;
    private float maxXPosition = 4.0f;
    
    private float minXPosition = -4.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float xVelovity = moveRight ? speed : -speed;

        // Calculate the velocity to move the capsule along the X-axis
        Vector3 velocity = new Vector3(xVelovity, rb.velocity.y, rb.velocity.z);

        // Apply the velocity to the Rigidbody
        rb.velocity = velocity;

         if (transform.position.x >= maxXPosition)
        {
            // Reverse the movement direction
            moveRight = false;
        } else if (transform.position.x <= minXPosition)
        {
            moveRight = true;
        }

        
    }
}
