using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    public GameObject MyPuzzle;
    public GameObject TheScene;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        MyPuzzle = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (tag == "SAFE")
        {
            Text.SetActive(false);
        }
        MyPuzzle.SetActive(false);
        
        TheScene.SetActive(true);
        

    }
}
