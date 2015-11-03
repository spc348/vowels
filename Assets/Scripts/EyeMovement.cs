using UnityEngine;

public class EyeMovement : MonoBehaviour
{
    private float maxDistance;
    private Vector3 originalPosition;

    // Use this for initialization
    private void Start()
    {
        originalPosition = transform.position;
        maxDistance = .15f;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void Look(Transform target)
    {
        Vector3 distanceToTarget = target.position - transform.position;
        distanceToTarget = Vector3.ClampMagnitude(distanceToTarget, maxDistance);
        transform.position = distanceToTarget + originalPosition;
    }

    public void LookAway()
    {
        transform.position = originalPosition;
    }
}