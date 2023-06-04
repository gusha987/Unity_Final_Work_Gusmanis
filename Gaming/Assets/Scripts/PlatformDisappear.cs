using UnityEngine;
using System.Collections;

public class PlatformDisappear : MonoBehaviour
{
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

       
            yield return new WaitForSeconds(disappearTime);

            platformRenderer.enabled = true;
            platformCollider.enabled = true;

           
            yield return new WaitForSeconds(appearTime);
        }
    }
}
