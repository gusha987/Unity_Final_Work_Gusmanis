using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switcher_1 : MonoBehaviour
    
{
    [Header("level")]
    public string requested_scene = "tutorial_2";
    void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene(requested_scene);
    }
}
