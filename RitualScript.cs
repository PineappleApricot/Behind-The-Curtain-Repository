using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualScript : MonoBehaviour
{
    public PuzzleDetectionScript PuzzleManager;
    public Sprite TargetSprite;
    public Collider2D MyCollider;
    public SpriteRenderer mySpriteRenderer;
    public AudioSource EvilLaugh;
    public AudioSource Ritual;
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
        if (PuzzleManager.ChalkCollected == true)
        {
            RugBurn.Play();
            Ritual.Play();
            RugBurn.Play();
            PuzzleManager.ChalkFilled = true;
            mySpriteRenderer.sprite = TargetSprite;
            gameObject.layer = 2;
            
        }

    }
}
