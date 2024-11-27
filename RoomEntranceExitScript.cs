using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEntranceExitScript : MonoBehaviour
{
    public GameObject RoomImIn;
    public GameObject RoomILeadTo;
    public MouseManager MouseManager;
    public GameObject Particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Particles.SetActive(false);
        RoomILeadTo.SetActive(true);
        MouseManager.NeedsChalk = false;
        MouseManager.NeedsLighter = false;
        MouseManager.CanBeEntered = false;
        MouseManager.MouseMystery = false;
        RoomImIn.SetActive(false);
    }
}
