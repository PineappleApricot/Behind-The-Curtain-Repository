using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPaintingUnlockScript : MonoBehaviour
{
    public PuzzleDetectionScript PuzzleManager;
    public GameObject Painting;
    public GameObject UnderneathPainting;
    public MouseManager MouseManager;
    public AudioSource PuzzleSolved;
    public AudioSource Open;
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
        if(PuzzleManager.KeyCollected == true)
        {
            Open.Play();
            PuzzleSolved.Play();
            PuzzleManager.PaintingOpened = true;
            UnderneathPainting.SetActive(true);
            MouseManager.NeedsKey = false;
            Painting.SetActive(false);
        }
    }
}
