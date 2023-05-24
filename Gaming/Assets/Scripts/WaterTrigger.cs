using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    private Transform playerTransform; // Reference to the player's transform
    private bool isPlayerInside; // Flag to check if the player is inside the trigger

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

    private void Update()
    {
        if (isPlayerInside && playerTransform != null)
        {
            // Make the player float on top of the trigger
            float triggerHeight = transform.position.y + transform.localScale.y / 2;
            playerTransform.position = new Vector3(playerTransform.position.x, triggerHeight, playerTransform.position.z);
        }
    }
}