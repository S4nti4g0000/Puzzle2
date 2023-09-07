using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twitter : MonoBehaviour
{

    public GameObject TheDoors;
    //public Collider2D openLobster;
    public Color itsOn;
    private bool onIt;
    int yn = 0;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Distroya"))
        {

            onIt = true;

        }
        

    }

    
 
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && onIt == true)
        {
            
            if(yn == 0)
            {
                Debug.Log("Wendussy");
                //openLobster.enabled = false;
                TheDoors.GetComponent<SpriteRenderer>().color = new Color(5,5,5,255);
                TheDoors.GetComponent<Collider2D>().enabled = false;
                yn = 1;

            }
            else { Debug.Log("Done"); }

        }

    }
}
