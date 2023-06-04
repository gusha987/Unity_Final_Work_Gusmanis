using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform startPoint; 
    public Transform endPoint; 
    public float speed = 2.0f; 
    private Vector3 targetPosition;

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
    }
}