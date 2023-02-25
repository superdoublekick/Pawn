using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private NavMeshAgent agent;
    private SurroundingCheck surroundingCheck;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        surroundingCheck = GetComponent<SurroundingCheck>();

        agent.speed = movementSpeed;
    }

    private void Update()
    {
        if (!surroundingCheck.IsSomethingAround)
            return;

        var targetPosition = surroundingCheck
            .DetectedColliders[0]
            .transform
            .position;

        agent.destination = targetPosition;
    }
}
