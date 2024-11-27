using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectionDetection : MonoBehaviour
{
    public PuzzleDetectionScript PuzzleManager;
    public GameObject miniChalk;
    public GameObject miniKey;
    public GameObject miniLighter;
    public AudioSource PickUpObject;
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
        if(gameObject.tag == "Key")
        {
            PuzzleManager.KeyCollected = true;
            miniKey.SetActive(true);
        }
        if (gameObject.tag == "Chalk")
        {
            PuzzleManager.ChalkCollected = true;
            miniChalk.SetActive(true);
        }
        if (gameObject.tag == "Lighter")
        {
            PuzzleManager.LighterCollected = true;
            miniLighter.SetActive(true);
        }
        PickUpObject.Play();
        Destroy(gameObject);



    }
}
