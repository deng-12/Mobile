using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerBehaviour : MonoBehaviour
{
    // A reference to the Rigidbody component
    /// <summary>
    /// A reference to the Rigidbody component 
    /// </summary>
    private Rigidbody rb;
    // How fast the ball moves left/right
    [Tooltip("How fast the ball moves left/right")]
    public float dodgeSpeed = 5;
    // How fast the ball moves forwards automatically
    [Tooltip("How fast the ball moves forwards automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // Get access to our Rigidbody component

        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    /// <summary>
    /// FixedUpdate is called at a fixed framerate and is a prime place to put 
    /// Anything based on time. 
    /// </summary>
    private void FixedUpdate()
    {
        // Check if we're moving to the side
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}
