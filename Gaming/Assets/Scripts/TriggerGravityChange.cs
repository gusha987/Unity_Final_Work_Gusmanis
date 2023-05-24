using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGravityChange : MonoBehaviour
{
  public float newGravity = -2f; // the new gravity value to set
    private CharacterController controller; // reference to the character controller component

    private void Start()
    {
// get the character controller component from the object this script is attached to
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // check if the player enters the trigger zone
        {
            controller = other.GetComponent<CharacterController>();
            controller.detectCollisions = false; // temporarily disable the character controller's collision detection to allow for gravity change
            controller.Move(Vector3.up * newGravity * Time.deltaTime); // apply the new gravity as a movement input to the character controller
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // check if the player exits the trigger zone
        {
            controller.detectCollisions = true; // re-enable the character controller's collision detection
        }
    }
}
