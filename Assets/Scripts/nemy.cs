using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nemy : MonoBehaviour
{
    //general
    public int mxH = 100;
    int curH;
    public Animator animator;

    //


    // Start is called before the first frame update
    void Start()
    {

        curH = mxH;  

    }


    public void Dmg(int dmg)
    {

        curH -= dmg;

        animator.SetTrigger("hurt");

        if(curH <= 0)
        {

            Die();

        }

    }

    void Die()
    {

        Debug.Log("ded");

        animator.SetBool("death",true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }
    

}
