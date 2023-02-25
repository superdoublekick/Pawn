using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int movementSpeed;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = 0;
        var vertical = 0;

        if(Input.GetKey(KeyCode.W))
            vertical = 1;
        
        if(Input.GetKey(KeyCode.S))
            vertical = -1;

        if(Input.GetKey(KeyCode.D))
            horizontal = 1;
        
        if(Input.GetKey(KeyCode.A))
            horizontal = -1;

        var movementVector = new Vector3(horizontal * movementSpeed, rb.velocity.y, vertical * movementSpeed);
        rb.velocity = movementVector;
    }
}
