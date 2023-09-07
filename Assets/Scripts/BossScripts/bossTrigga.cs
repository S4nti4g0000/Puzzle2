using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossTrigga : MonoBehaviour
{
    private daBaby enemyParent;

    private void Awake()
    {

        enemyParent = GetComponentInParent<daBaby>();

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.CompareTag("Distroya"))
        {

            gameObject.SetActive(false);
            enemyParent.target = coll.transform;
            enemyParent.inRange = true;
            enemyParent.hotAF.SetActive(true);

        }

    }

}
