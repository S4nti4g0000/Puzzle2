using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenSceneManage : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("MainLevel");
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("MENU");
    }
}
