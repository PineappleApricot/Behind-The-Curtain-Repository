using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BookDetection : MonoBehaviour
{
    public GameObject TargetBook;
    public DragScript TargetBookScript;
    public bool isTouchingTarget;
    public bool alreadyHasABook;
    public bool bookLockedIn;
    public GameObject OurObject;
    public AudioSource Clicky;
    // Start is called before the first frame update
    void Start()
    {
        TargetBookScript = TargetBook.GetComponent<DragScript>();
        alreadyHasABook = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Book")
        {
            if (alreadyHasABook == false)
            {
                if (collision.gameObject.GetComponent<DragScript>().dragging == false)
                {

                    OurObject = collision.gameObject;
                    collision.gameObject.transform.position = gameObject.transform.position;
                    Clicky.Play();
                    collision.gameObject.GetComponent<DragScript>().LockedIn = true;
                    bookLockedIn = true;
                    alreadyHasABook = true;
                    if (collision.gameObject == TargetBook)
                    {
                        isTouchingTarget = true;
                    }
                    else
                    {
                        isTouchingTarget = false;
                    }
                          
                    
                }
               
            }
        
        }
        
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag== "Book")
        {
            if(collision.gameObject.GetComponent<DragScript>().LockedIn == true && collision.gameObject == OurObject)
            {
                alreadyHasABook = false;
                isTouchingTarget = false;
                bookLockedIn =false;
            }
            else
            {
                
            }
               
            
            
        }
        
    }
}
