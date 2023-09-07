using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes_Fall : MonoBehaviour
{

    private bool touchPlayer;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Distroya"))
        {

            touchPlayer = true;

        }
    }

    void Update()
    {

        if (touchPlayer == true)
        {

            transform.Translate(Vector3.down * Time.deltaTime * 10);

        }

    }
}
