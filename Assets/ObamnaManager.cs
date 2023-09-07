using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObamnaManager : MonoBehaviour
{

    public TMP_Text scoringBussy;

    Player slayer;

    void Start()
    {
        slayer = GameObject.Find("Character_0").GetComponent<Player>();

        scoringBussy.text = "Lives: " + slayer.lives;
    }

    public void Death()
    {

        

    }
}
