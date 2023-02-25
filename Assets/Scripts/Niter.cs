using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niter: MonoBehaviour
{

    private GroundCheck groundCheck;
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision) 
    {
        if(!groundCheck.OnGround) {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    
}
