using UnityEngine;

public class BallManager : MonoBehaviour
{
    private Rigidbody rb; // Rigidbody of the ball

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the ball's rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Calls whenever the character collides with another collider or rigidbody
    void OnCollisionEnter(Collision other)
    {
        // Activate gravity it's not already activated
        if (!rb.useGravity)
        {
            rb.useGravity = true;
        }
    }
}
