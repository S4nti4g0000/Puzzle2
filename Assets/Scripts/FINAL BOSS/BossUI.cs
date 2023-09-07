using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossUI : MonoBehaviour
{

    public GameObject bossPanel;
    public GameObject muros;

    public static BossUI instance;

    void Awake()
    {

        if(instance == null)
        {
            instance = this;

        }

    }

    void Start()
    {
        bossPanel.SetActive(false);
        muros.SetActive(false);
    }

    public void BossActivator()
    {

        bossPanel.SetActive(true);
        muros.SetActive(true);
    }
}
