using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthRegen : MonoBehaviour
{

    Player daHealed;

    void Start()
    {
        daHealed = GameObject.Find("Character_0").GetComponent<Player>();
    }

    
    void OnTriggerEnter2D(Collider2D player)
    {

        if (player.CompareTag("Distroya"))
        {


            if(daHealed.currHelth < 100)
            {

                daHealed.pHeal(25);
                Destroy(this.gameObject);

            }
            


        }


    }

}
