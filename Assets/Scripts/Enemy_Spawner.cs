using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    public GameObject evilPrefab;
    public GameObject THATSLIKESOOOCOOLOMGWOWAMAZING;
    public int deathCount = 0;

    daBaby baby;

    void Start()
    {
        baby = GameObject.Find("EnemyBussy_Prefab Variant").GetComponent<daBaby>();
        StartCoroutine(daddySpawner());
    }

    void Update()
    {
        if(deathCount >= 16)
        {

            THATSLIKESOOOCOOLOMGWOWAMAZING.SetActive(true);

        }
    }

    IEnumerator daddySpawner()
    {
        while(deathCount <= 15)
        {

            Instantiate(evilPrefab, new Vector3(Random.Range(-6f, 6f), Random.Range(15f, 4f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);

        }
        

    }

}
