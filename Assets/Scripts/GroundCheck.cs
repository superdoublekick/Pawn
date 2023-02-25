using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    [SerializeField] private LayerMask terrainLayerMask;
    [SerializeField] private float checkRadius;
    public bool OnGround { get; private set; }
    void Update()
    {
        Collider[] hitInfo = Physics.OverlapSphere(transform.position, checkRadius, terrainLayerMask);
        OnGround = hitInfo.Length > 0;   
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}
