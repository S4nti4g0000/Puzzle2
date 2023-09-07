using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivation : MonoBehaviour
{

    Player player;

    void Start()
    {
        player = GameObject.Find("Character_0").GetComponent<Player>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {       

        if (other.CompareTag("Distroya"))
        {

            BossUI.instance.BossActivator();

            StartCoroutine(WaitForBoss());

        }
                
    }

    IEnumerator WaitForBoss()
    {

        float CurrentSpeed = player._cumSpeed;
        player._cumSpeed = 0f;
        yield return new WaitForSeconds(3f);
        player._cumSpeed = CurrentSpeed;
        Destroy(gameObject);


    }
}
