using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDetect : MonoBehaviour
{
    public float ButtonNumber;
    public Text SafeText;
    public GameObject Safe;
    public GameObject SafeUnderneath;
    public PuzzleDetectionScript PuzzleManager;
    public AudioSource Boop;
    public AudioSource Erer;
    public AudioSource Success;
    public AudioSource Open;
    public float Timer;
    public bool canType = true;
    public bool timeToCheck = false;
    // This function is called every frame, checking for mouse click
    private void Start()
    {
        canType = true;

        Safe = gameObject.transform.parent.gameObject;
    }
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log("Object Clicked!");
        if(canType == true)
        {
            if (SafeText.text.Length < 3)
            {
                SafeText.text += ButtonNumber;
                Boop.Play();
            }
            else
            {
                SafeText.text += ButtonNumber;
                Boop.Play();
                timeToCheck = true;
                SafeTextCheck();

            }
        }
        
        
    }
    void SafeTextCheck()
    {
        if(SafeText.text == "5856")
        {
            SafeText.color = Color.green;
            
            Success.Play();
            
            Debug.Log("Right Code!");
            
            
            
        }
        else
        {
            SafeText.color = Color.red;
            Erer.Play();
            Debug.Log("Womp Womp");
        }
    }
    void FixedUpdate()
    {
        if (Timer < 0.5f)
        {
            if(timeToCheck == true)
            {
                canType = false;
                Timer += Time.deltaTime;
            }
            
        }
        else
        {
            if (SafeText.text == "5856")
            {
                SafeUnderneath.SetActive(true);
                Safe.SetActive(false);
                PuzzleManager.SafePuzzleSolved = true;
                Open.Play();
            }
            timeToCheck = false;
            Timer = 0;
            SafeText.text = "";
            SafeText.color = Color.white;
            canType = true;
        }
        
    }
}
