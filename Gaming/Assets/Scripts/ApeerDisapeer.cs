using UnityEngine;
using System.Collections;

public class ApeerDisapeer : MonoBehaviour
{
    public GameObject targetPlatform;  
    public float disappearTime = 2.0f; 
    public float appearTime = 2.0f;    
    private Renderer platformRenderer;
    private Collider platformCollider;

    private void Start()
    {
        platformRenderer = GetComponent<Renderer>();
        platformCollider = GetComponent<Collider>();

        
        StartCoroutine(DisappearAndAppear());
    }

    private IEnumerator DisappearAndAppear()
    {
        while (true)
        {
            
            platformRenderer.enabled = false;
            platformCollider.enabled = false;
            targetPlatform.SetActive(true); 

            
            yield return new WaitForSeconds(disappearTime);

            
            platformRenderer.enabled = true;
            platformCollider.enabled = true;
            targetPlatform.SetActive(false); 

            
            yield return new WaitForSeconds(appearTime);
        }
    }
}