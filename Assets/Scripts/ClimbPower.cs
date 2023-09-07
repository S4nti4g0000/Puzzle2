using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClimbPower : MonoBehaviour
{

    Player distroyaReal;
    public int pussyId;

    string sceneName;

    spawnObamna spawn;

    void Start()
    {

        Scene currentScene = SceneManager.GetActiveScene();

        sceneName = currentScene.name;

        if(sceneName != "LevelTree" && sceneName != "LevelOne")
        {
            spawn = GameObject.Find("JumpSpawn").GetComponent<spawnObamna>();
        }

        distroyaReal = GameObject.Find("Character_0").GetComponent<Player>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        
        if (other.CompareTag("Distroya"))
        {
            
            
            if(distroyaReal != null)
            {

                distroyaReal.ClimbOn = true;
                

            }
            
            Destroy(this.gameObject);
            spawn.groped = true;

            //omgItSounds.Play();


        }

        if(pussyId == 1)
        {
           
            distroyaReal.canJumpMore();

        }

        if(pussyId == 2)
        {
            
            distroyaReal.canCumALot();

        }

        if(pussyId == 3)
        {
            
            distroyaReal.ohWowHeDoesNotSkipLegDay();

        }


    }

    
}
