using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugScript : MonoBehaviour
{
    public PuzzleDetectionScript PuzzleManager;
    public GameObject Room3Entrance;
    public AudioSource RugBurn;
    public AudioSource PuzzleSolved;
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
        if(PuzzleManager.LighterCollected == true)
        {
            RugBurn.Play();
            Particles.SetActive(true);
            PuzzleSolved.Play();
            PuzzleManager.RugBurnt = true;
            Room3Entrance.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }
}
