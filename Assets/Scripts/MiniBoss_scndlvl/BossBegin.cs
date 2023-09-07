using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBegin : MonoBehaviour
{

    BossFollow boss;
    public Collider2D bColl;
    public Collider2D thisOne;
    public GameObject RUN;

    void Start()
    {
        boss = GameObject.Find("MiniBoss").GetComponent<BossFollow>();
    }

    void OnTriggerEnter2D(Collider2D pp)
    {

        if (pp.CompareTag("Distroya"))
        {

            boss.enabled = true;
            StartCoroutine(turnOn());
            bColl.enabled = true;
            thisOne.enabled = false;

        }

    }

    IEnumerator turnOn()
    {

        RUN.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(turnOff());

    }

    IEnumerator turnOff()
    {

        RUN.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(turnOn());

    }
}
