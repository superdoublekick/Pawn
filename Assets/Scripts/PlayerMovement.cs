using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int movementSpeed;

    private Rigidbody rb;

    private GroundCheck groundCheck;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundCheck = GetComponent<GroundCheck>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = 0;
        var vertical = 0;
        var jump = rb.velocity.y;

        if(Input.GetKey(KeyCode.W))
            vertical = 1;
        
        if(Input.GetKey(KeyCode.S))
            vertical = -1;

        if(Input.GetKey(KeyCode.D))
            horizontal = 1;
        
        if(Input.GetKey(KeyCode.A))
            horizontal = -1;

        if(Input.GetKey(KeyCode.Space) && groundCheck.OnGround) 
            jump = 1 * movementSpeed;

        var movementVector = new Vector3(horizontal * movementSpeed, jump, vertical * movementSpeed);
        rb.velocity = movementVector;
        

    }
}
