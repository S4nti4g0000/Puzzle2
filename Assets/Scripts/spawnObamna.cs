using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObamna : MonoBehaviour
{

    public GameObject obamaJump;
    public bool groped = false;

    void Update()
    {

        if (groped == true)
        {
            InvokeRepeating("SpawnDaBoi", 2.0f, 2.0f);
        }
        else
        {
            CancelInvoke("SpawnDaBoi");
        }

    }

    void SpawnDaBoi()
    {

        Instantiate(obamaJump, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        groped = false;

    }
   
            
     

}
