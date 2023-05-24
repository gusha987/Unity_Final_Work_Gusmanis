using UnityEngine;

public class LevitateOnTrigger : MonoBehaviour
{
    public float speed = 2f; // The speed of the levitation
    public float height = 1f; // The maximum height of the levitation

    private CharacterController controller; // Reference to the CharacterController component
    private float initialY; // The initial Y position of the object

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        controller = other.GetComponent<CharacterController>(); // Get a reference to the CharacterController component
        initialY = transform.position.y; // Store the initial Y position of the object
        if (other.gameObject.CompareTag("Player")) // Check if the object that entered the trigger is the player
        {
            // Enable the levitation effect
            enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Check if the object that exited the trigger is the player
        {
            // Disable the levitation effect
            enabled = false;
            // Reset the object's Y position to its initial position
            
        }
    }

    void Update()
    {

        if (enabled) // Check if the levitation effect is enabled
        {
            // Calculate the new Y position based on a sine wave
            float newY = initialY + Mathf.Sin(Time.time * speed) * height;

            // Move the object's position using the CharacterController component
            controller.Move(new Vector3(0, newY - transform.position.y, 0));
        }
    }
}
