using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cumBlast : MonoBehaviour
{

    public float KumisSpeed = 100.0f;
    private GameObject chara;

    Player player;

    void Start()
    {

        player = GameObject.Find("Character_0").GetComponent<Player>();
        chara = GameObject.Find("Character_0");

    }

   
    void Update()
    {
        if(chara.transform.localScale.x > 0)
        {
            transform.Translate(Vector3.right * KumisSpeed * Time.deltaTime);
        }
        if(chara.transform.localScale.x < 0)
        {
            transform.Translate(Vector3.left * KumisSpeed * Time.deltaTime);
        }
             

        if(transform.position.x >= 9)
        {
            Destroy(this.gameObject);
        }
        else if (transform.position.x <= -9)
        {
            Destroy(this.gameObject);
        }
    }
}
