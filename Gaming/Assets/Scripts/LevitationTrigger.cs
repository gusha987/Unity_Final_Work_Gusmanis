using UnityEngine;

public class LevitationTrigger : MonoBehaviour
{
    public float floatSpeed = 5f; // The speed at which the player goes up

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController characterController = other.GetComponent<CharacterController>();
            if (characterController != null)
            {
                characterController.Move(Vector3.up * floatSpeed * Time.deltaTime);
            }
        }
    }
}