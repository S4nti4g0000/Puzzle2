using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canGoDown : MonoBehaviour
{

    private PlatformEffector2D pierceThePlatform;
    [HideInInspector] public LayerMask chara;
    private bool touchingPP;
    public Collider2D bbCol;
    float waitTime;

    void Start()
    {

        pierceThePlatform = GetComponent<PlatformEffector2D>();

        chara = LayerMask.GetMask("Distroya");

    }

    void Update()
    {

        if (touchingPP = bbCol.IsTouchingLayers(chara))
        {

            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {


                if (waitTime <= 0)
                {

                    pierceThePlatform.rotationalOffset = 180;
                    waitTime = 0.5f;
                    //bbCol.enabled = false;

                }

            }
            else
            {

                waitTime -= Time.deltaTime;

            }

            

        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {

            pierceThePlatform.rotationalOffset = 0;

        }

    }

    
}


    

