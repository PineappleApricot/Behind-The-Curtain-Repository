using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScript : MonoBehaviour
{
    public PuzzleDetectionScript PuzzleManager;
    public Sprite TargetSprite;
    public SpriteRenderer mySpriteRenderer;
    public GameObject CandleLights;
    public AudioSource PuzzleSolved;
    public AudioSource RugBurn;
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
        if (PuzzleManager.LighterCollected == true)
        {
            RugBurn.Play();
            PuzzleSolved.Play();
            PuzzleManager.CandlesLit = true;
            mySpriteRenderer.sprite = TargetSprite;
            CandleLights.SetActive(true);
            gameObject.layer = 2;
        }

    }
}
