using UnityEngine;

public class FanTrigger : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Transform playerTransform;
    private bool isPlayerInside;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = true;
            playerTransform = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInside = false;
            playerTransform = null;
        }
    }

    private void FixedUpdate()
    {
        if (isPlayerInside && playerTransform != null)
        {
            float triggerHeight = transform.position.y + transform.localScale.y / 2;

            Vector3 targetPosition = new Vector3(playerTransform.position.x, triggerHeight, playerTransform.position.z);
            playerTransform.position = Vector3.Lerp(playerTransform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}