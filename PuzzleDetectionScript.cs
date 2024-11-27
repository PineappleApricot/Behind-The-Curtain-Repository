using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class PuzzleDetectionScript : MonoBehaviour
{
    
    public GameObject FullScene1;
    public GameObject BookPuzzle;
    public GameObject BookShelfMini;
    public GameObject Room2Entrance;
    public GameObject BookDetector1;
    public GameObject BookDetector2;
    public GameObject BookDetector3;
    public GameObject BookDetector4;
    public GameObject BookDetector5;
    
    public GameObject CardDetector1;
    public GameObject CardDetector2;
    public GameObject CardDetector3;
    public GameObject CardDetector4;
    public GameObject CardDetector5;
    
    public GameObject CardDetector6;
    public GameObject CardDetector7;
    public GameObject CardDetector8;
    public GameObject CardDetector9;
    public GameObject CardDetector10;
    public GameObject Chalk;
    public bool SafePuzzleSolved;
    public bool BookPuzzleSolved;
    public bool KeyCollected;
    public bool PaintingOpened;
    public bool LighterCollected;
    public bool RugBurnt;
    public bool ChalkCollected;
    public bool CandlesLit;
    public bool ChalkFilled;
    public bool CardPuzzleSolved;
    public GameObject GlowyParticles;
    public GameObject Safe;
    public GameObject Shelf;
    public GameObject Painting;
    public AudioSource PuzzleSolved;
    public AudioSource ChairSlide;
 //   public AudioSource FireCrackle;
   // public AudioSource OpenSesame;
   // public AudioSource ItemCollected;
    public GameObject Ending;
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        BookDetector1.GetComponent<BookDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BookDetector1.GetComponent<BookDetection>().isTouchingTarget == true && BookDetector2.GetComponent<BookDetection>().isTouchingTarget == true && BookDetector3.GetComponent<BookDetection>().isTouchingTarget == true && BookDetector4.GetComponent<BookDetection>().isTouchingTarget == true && BookDetector5.GetComponent<BookDetection>().isTouchingTarget == true)
        {
            BookPuzzleSolved = true;
            Debug.Log("BookPuzzleSolved");
            BookPuzzle.SetActive(false);
            FullScene1.SetActive(true);
            BookShelfMini.GetComponent<Animator>().SetTrigger("BookPuzzleSolved");
            BookShelfMini.GetComponent<PuzzleClickedDetection>().enabled = false;
            BookShelfMini.GetComponent<BoxCollider2D>().enabled = false;
            BookShelfMini.GetComponent<HoverDetection>().enabled = false;
            ChairSlide.Play();
            PuzzleSolved.Play();
            
            Room2Entrance.SetActive(true);
        }
        if(CardDetector1.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector2.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector3.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector4.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector5.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector6.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector7.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector8.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector9.GetComponent<BookDetection>().isTouchingTarget == true && CardDetector10.GetComponent<BookDetection>().isTouchingTarget == true)
        {
            Chalk.SetActive(true);
            CardPuzzleSolved = true;
            PuzzleSolved.Play();
        }
        if(CandlesLit == true)
        {
           // FireCrackle.Play();
            GlowyParticles.SetActive(true);
        }
        if(SafePuzzleSolved == true)
        {
            //OpenSesame.Play();
            Safe.SetActive(true);
            Safe.GetComponent<Animator>().Play("SafeOpen");
            
        }
        if (PaintingOpened == true)
        {
            //OpenSesame.Play();
            Painting.SetActive(true);
            Painting.GetComponent<Animator>().Play("Open");
            
        }
        if (ChalkCollected == true || LighterCollected == true || KeyCollected == true)
        {
            //ItemCollected.Play();
        }
        if (ChalkFilled == true)
        {
            Door.SetActive(false);
            Ending.GetComponent<Animator>().SetTrigger("Trigger");

        }
    }
}
