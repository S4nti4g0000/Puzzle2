using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtt : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Distroya"))
        {

            Debug.Log("dedddd");

        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
