using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public bool CanBeEntered;
    public bool NeedsLighter;
    public bool NeedsChalk;
    public bool MouseMystery;
    public bool NeedsKey;
    public SpriteRenderer TargetRenderer;
    public Sprite CanBeEnteredSprite;
    public Sprite NeedsLighterSprite;
    public Sprite NeedsChalkSprite;
    public Sprite MouseMysterySprite;
    public Sprite NeedsKeySprite;
    public Sprite NoSprite;
    public PuzzleDetectionScript PuzzleManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CanBeEntered == true)
        {
            TargetRenderer.sprite = CanBeEnteredSprite;
        }
        
        if (NeedsLighter == true)
        {
            if(PuzzleManager.LighterCollected == true)
            {
                TargetRenderer.sprite = NeedsLighterSprite;
            }
            else
            {
                TargetRenderer.sprite = MouseMysterySprite;
                MouseMystery = true;
            }
        }
        if (NeedsKey == true)
        {
            if (PuzzleManager.KeyCollected == true)
            {
                TargetRenderer.sprite = NeedsKeySprite;
            }
            else
            {
                TargetRenderer.sprite = MouseMysterySprite;
                MouseMystery = true;
            }
        }

        if (NeedsChalk == true)
        {
            if (PuzzleManager.ChalkCollected == true)
            {
                TargetRenderer.sprite = NeedsChalkSprite;
            }
            else
            {
                MouseMystery = true;
                TargetRenderer.sprite = MouseMysterySprite;
            }
        }
        if(NeedsLighter == false && MouseMystery == false && NeedsChalk == false && CanBeEntered == false && NeedsKey == false)
        {
            TargetRenderer.sprite = NoSprite;
        }
        
    }
}
