using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHit : MonoBehaviour
{
    public Player slayer;
    public helthPlayer helthBar;


    void OnTriggerEnter2D(Collider2D slay)
    {



        if (slay.gameObject.tag == "Distroya")
        {

            pDmg(10);

        }

    }

    void pDmg(int dmg)
    {

        slayer.currHelth -= dmg;
        helthBar.SetHealth(slayer.currHelth);

    }
}
