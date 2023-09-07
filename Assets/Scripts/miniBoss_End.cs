using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniBoss_End : MonoBehaviour
{
    BossFollow boss;
    BossBegin textRepeating;
    public Collider2D bColl;
    public Collider2D thisOne;
    public GameObject RUN;

    void Start()
    {
        boss = GameObject.Find("MiniBoss").GetComponent<BossFollow>();
        textRepeating = GameObject.Find("miniBoss_Begin").GetComponent<BossBegin>();
    }


    void OnTriggerEnter2D(Collider2D pp)
    {

        if (pp.CompareTag("Distroya"))
        {

            boss.enabled = false;
            textRepeating.enabled = false;
            RUN.SetActive(false);

        }

    }

}
