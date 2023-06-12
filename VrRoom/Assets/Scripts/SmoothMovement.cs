using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public Transform targetPosition;
    public float movementSpeed = 5f;

    private Vector3 startPosition;
    private float startTime;
    private float journeyLength;

    private void Start()
    {
        startPosition = transform.position;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPosition, targetPosition.position);
    }

    private void Update()
    {
        float distCovered = (Time.time - startTime) * movementSpeed;
        float fractionOfJourney = distCovered / journeyLength;

        transform.position = Vector3.Lerp(startPosition, targetPosition.position, fractionOfJourney);
    }
}
