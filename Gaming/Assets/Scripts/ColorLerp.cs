using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    public float lerpDuration = 1f;

    private Renderer renderer;
    private float lerpStartTime;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        lerpStartTime = Time.time;
    }

  
    private void Update()
    {
        
        float lerpTime = (Time.time - lerpStartTime) / lerpDuration;

       
        lerpTime = Mathf.Clamp01(lerpTime);

        Color currentColor = Color.Lerp(startColor, endColor, lerpTime);

        
        renderer.material.color = currentColor;

        
        if (lerpTime == 1f)
        {
            
            Color tempColor = startColor;
            startColor = endColor;
            endColor = tempColor;

           
            lerpStartTime = Time.time;
        }
    }
}