using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hottieCheck : MonoBehaviour
{

    private daBaby enemyParent;
    private bool inRange;
    private Animator anim;

    private void Awake()
    {

        enemyParent = GetComponentInParent<daBaby>();
        anim = GetComponentInParent<Animator>();

    }

    private void Update()
    {

        if (inRange && !anim.GetCurrentAnimatorStateInfo(0).IsName("enemy07"))
        {

            enemyParent.Flipy();

        }

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.CompareTag("Distroya"))
        {

            inRange = true;

        }


    }

    private void OnTriggerExit2D(Collider2D coll)
    {

        if (coll.gameObject.CompareTag("Distroya"))
        {

            inRange = false;
            gameObject.SetActive(false);
            enemyParent.triggerArea.SetActive(true);
            enemyParent.inRange = false;
            enemyParent.SelectTarget();

        }

    }

}