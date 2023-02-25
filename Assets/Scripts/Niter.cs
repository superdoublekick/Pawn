using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niter: MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private SurroundingCheck surrondingCheck;
    public float life = 3;

    void Awake()
    {
        surrondingCheck = GetComponent<SurroundingCheck>();

        Destroy(gameObject, life);
    }

    private void Update()
    {
        Move();

        if (!surrondingCheck.IsSomethingAround)
            return;

        var target = surrondingCheck.DetectedColliders[0].transform;
        Destroy(target.gameObject);
    }

    private void Move()
    {
        transform.position = transform.position + Vector3.forward * movementSpeed * Time.deltaTime;
    }
}
