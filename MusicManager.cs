using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public PuzzleDetectionScript PuzzleManager;
    public AudioSource Bass;
    public AudioSource Drums1;
    public AudioSource Drums2;
    public AudioSource HighStrings;
    public AudioSource HighVoice;
    public AudioSource LowVoice;
    public AudioSource Organ1;
    public AudioSource Organ2;
    public AudioSource Organ3;
    public AudioSource ThePlotThickens;
    public float Volumes;
    // Start is called before the first frame update
    void Start()
    {
        Volumes = 0.6f;
        Bass.Play();
        Drums1.Play();
        HighStrings.Play();
        HighVoice.Play();
        LowVoice.Play();
        Organ1.Play();
        Organ2.Play();
        Organ3.Play();
        ThePlotThickens.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(PuzzleManager.BookPuzzleSolved == true)
        {
            Bass.volume = Volumes;
        }
        if (PuzzleManager.SafePuzzleSolved == true)
        {
            Organ1.volume = Volumes;
            
            
        }
        if (PuzzleManager.KeyCollected == true)
        {
            Organ2.volume = Volumes;
        }
        if (PuzzleManager.PaintingOpened == true)
        {
            Organ3.volume = Volumes;
        }
        if (PuzzleManager.RugBurnt == true)
        {
            LowVoice.volume = Volumes;
        }
        if (PuzzleManager.ChalkCollected == true)
        {
            HighStrings.volume = Volumes;
        }
        if (PuzzleManager.CandlesLit == true)
        {
            LowVoice.volume = Volumes;
        }
        if (PuzzleManager.CardPuzzleSolved == true)
        {
            Drums1.volume = Volumes;
        }
        if (PuzzleManager.ChalkFilled == true)
        {
            HighVoice.volume = Volumes;
        }

    }
}
