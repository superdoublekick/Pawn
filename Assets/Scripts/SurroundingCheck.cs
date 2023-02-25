using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurroundingCheck : MonoBehaviour
{
    [SerializeField] private LayerMask detectionLayerMask;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float checkRadius;

    public bool IsSomethingAround { get; private set; }
    public Collider[] DetectedColliders { get; private set; }

    void Update()
    {
        var hitInfo = Physics.OverlapSphere(
            transform.position + offset,
            checkRadius,
            detectionLayerMask);

        IsSomethingAround = hitInfo.Length > 0;

        if (IsSomethingAround)
            DetectedColliders = hitInfo;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, checkRadius);
    }
}
