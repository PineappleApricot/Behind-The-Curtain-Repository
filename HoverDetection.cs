using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverDetection : MonoBehaviour
{
    private Vector3 originalScale;
    public bool isHoveredOn;
    public float hoverScale;

    void Start()
    {
        isHoveredOn = false;
        // Store the original scale of the object
        originalScale = transform.localScale;
    }

    void Update()
    {
        
    }
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        transform.localScale = new Vector3(originalScale.x +hoverScale, originalScale.y + hoverScale, hoverScale);
        isHoveredOn = true;
    }

    void OnMouseExit()
    {
        isHoveredOn = false;
        transform.localScale = originalScale;
        //The mouse is no longer hovering over the GameObject so output this message each frame
        
    }
}