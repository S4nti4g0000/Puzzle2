using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    //Player playerScript;


    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public float ParSpeed = 2f;

    void Start()
    {
        //playerScript = GetComponent<Player>();
        

    }

    
    void Update()
    {

        MegaPint();
        
    }

    private void MegaPint()
    {

        var cCum = GameObject.Find("Character_0").GetComponent<Player>();
        float movingChar = Input.GetAxis("Horizontal");

        if (movingChar > 0f)
            {

            bg3.transform.Translate(Vector3.left * Time.deltaTime * ParSpeed * movingChar);
            bg2.transform.Translate(Vector3.left * Time.deltaTime * (ParSpeed-1) * movingChar);


        }
        else if(movingChar < 0f)
        {
            bg3.transform.Translate(Vector3.right * Time.deltaTime * (ParSpeed*-1f) * movingChar);
            bg2.transform.Translate(Vector3.right * Time.deltaTime * (ParSpeed*-0.5f) * movingChar);
        }
            

    }
}
