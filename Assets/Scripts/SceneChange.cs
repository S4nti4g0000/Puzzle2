using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private bool inDoor;
    [HideInInspector] public int whichDoor = 0;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Distroya"))
        {

            inDoor = true;

        }

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }

        switch (whichDoor)
        {

            case 1:

                if (inDoor == true && Input.GetKeyDown(KeyCode.E))
                {

                    Debug.Log("lol");
                    SceneManager.LoadScene("LevelOne", LoadSceneMode.Single);

                }
                

                break;

            case 2:


                if (inDoor == true && Input.GetKeyDown(KeyCode.E))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                    SceneManager.LoadScene("LevelTwo", LoadSceneMode.Single);

                }

                break;

            case 3:

                if (inDoor == true && Input.GetKeyDown(KeyCode.E))
                {

                    Debug.Log("lol 2");

                }

                break;

            case 4:

                if(inDoor == true && Input.GetKeyDown(KeyCode.E))
                {
                    
                    SceneManager.LoadScene("MainLevel", LoadSceneMode.Single);

                }
                break;

        }



        
    }
}
