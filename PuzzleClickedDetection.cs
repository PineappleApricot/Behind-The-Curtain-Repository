using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleClickedDetection : MonoBehaviour
{
    public GameObject MyPuzzle;
    public GameObject TheScene;
    public GameObject Text;
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
        if (tag == "SAFE")
        {
            Text.SetActive(true);
        }
        MyPuzzle.SetActive(true);
        
        TheScene.SetActive(false);
        

    }
}
