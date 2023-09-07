using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoss : MonoBehaviour
{
    public int life;
    public int maxLife = 150;
    private Animator anim;

    void Start()
    {

        life = maxLife;

        anim = GetComponentInParent<Animator>();

    }

    public void eDmg(int enDmg)
    {

        life -= enDmg;
        //anim.SetTrigger("hurt");

        if (life <= 0)
        {
            //anim.SetBool("Dead", true);
            DeadBoi();
        }

    }

    void DeadBoi()
    {

        daBaby bby = GetComponentInParent<daBaby>();


        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        Debug.Log("Imded");
        bby.DedBoi();

    }

}
