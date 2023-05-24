using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public Transform teleportLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportLocation.position;

            other.transform.rotation = teleportLocation.rotation;
        }
    }
}