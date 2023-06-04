using UnityEngine;

public class MovyPlatform : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint; 
    public float speed = 2.0f; 

    private Vector3 targetPosition;
    private bool playerOnPlatform = false;
    private Transform playerTransform;
    private Vector3 playerPlatformOffset;

    private void Start()
    {
        
        targetPosition = startPoint.position;
    }

    private void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        
        if (transform.position == targetPosition)
        {
           
            if (targetPosition == startPoint.position)
            {
                targetPosition = endPoint.position;
            }
            
            else if (targetPosition == endPoint.position)
            {
                targetPosition = startPoint.position;
            }
        }

        
        if (playerOnPlatform)
        {
            Vector3 newPos = playerTransform.position + playerPlatformOffset;
            playerTransform.position = newPos;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnPlatform = true;
            playerTransform = other.transform;
            playerPlatformOffset = playerTransform.position - transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && playerOnPlatform)
        {
            playerOnPlatform = false;
            playerTransform = null;
        }
    }
}