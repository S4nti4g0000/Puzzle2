using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgPP : MonoBehaviour
{

    Player slayer;
    public helthPlayer helthBar;

    public bool touchFemboy;

    void Start()
    {
        slayer = GameObject.Find("Character_0").GetComponent<Player>();
    }



    void OnTriggerEnter2D(Collider2D pp)
    {

        if (pp.CompareTag("Distroya"))
        {

            Debug.Log("Im dying");
            touchFemboy = true;

            if(touchFemboy == true)
            {

                InvokeRepeating("Kira", 0.1f, 0.2f);

            }
                
            //

        }

    }

    void OnTriggerExit2D(Collider2D pp)
    {

        if (pp.CompareTag("Distroya"))
        {

            Debug.Log("I stopped dying");
            touchFemboy = false;
            CancelInvoke("Kira");

        }

    }

    void Kira()
    {

        pDmg(1);

    }

    void pDmg(int dmg)
    {

        slayer.currHelth -= dmg;
        helthBar.SetHealth(slayer.currHelth);

    }

}
