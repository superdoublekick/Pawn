using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float radius;

    private SurroundingCheck surroundingCheck;

    private void Start()
    {
        surroundingCheck = GetComponent<SurroundingCheck>();
    }

    private void Update()
    {
        if (!surroundingCheck.IsSomethingAround)
            return;

        var targetPosition = surroundingCheck.
            DetectedColliders[0]
            .transform
            .position;
        var distanceToTarget = (targetPosition - transform.position).sqrMagnitude;
        if (distanceToTarget <= radius * radius)
        {
            var target = surroundingCheck.
                DetectedColliders[0]
                .gameObject;
            Destroy(target);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
