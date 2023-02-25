using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int movementSpeed;

    private Rigidbody rb;

    private SurroundingCheck surroundingCheck;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        surroundingCheck = GetComponent<SurroundingCheck>();
    }

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

        if(Input.GetKey(KeyCode.Space) && surroundingCheck.IsSomethingAround)
            jump = 1 * movementSpeed;

        var movementVector = new Vector3(horizontal * movementSpeed, jump, vertical * movementSpeed);
        rb.velocity = movementVector;
    }
}
