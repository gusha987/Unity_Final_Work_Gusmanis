using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switcher_1 : MonoBehaviour
    
{
    [Header("level")]
    public string requested_scene = "lvl";
    public bool showMouseCursor = true;

    private void Start()
    {
        if (showMouseCursor)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene(requested_scene);
    }
}
