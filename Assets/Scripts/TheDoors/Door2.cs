using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{


    public int sceneBuildIndex;

    void OnTriggerStay2D(Collider2D other)
    {

        if(other.CompareTag("Distroya"))
        {
            Debug.Log("ci1");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("ci");
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }

        }

    }
}
