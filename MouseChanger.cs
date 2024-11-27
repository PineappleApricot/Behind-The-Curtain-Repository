using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChanger : MonoBehaviour
{
    public MouseManager MouseManager;
    // Start is called before the first frame update
  
    // Update is called once per frame
    void Update()
    {
        
    }
    void Start()
    {
        
    }
    void OnMouseOver()
    {
        if(gameObject.tag == "YouCanEnter")
        {
            MouseManager.CanBeEntered = true;
        }
        if (gameObject.tag == "NeedsLighter")
        {
            MouseManager.NeedsLighter = true;
        }
        if (gameObject.tag == "NeedsChalk")
        {
            MouseManager.NeedsChalk = true;
        }
        if (gameObject.tag == "NeedsKey")
        {
            MouseManager.NeedsKey = true;
        }

    }

    void OnMouseExit()
    {
        MouseManager.NeedsChalk = false;
        MouseManager.NeedsLighter = false;
        MouseManager.CanBeEntered = false;
        MouseManager.MouseMystery = false;
        MouseManager.NeedsKey = false;
    }


}

