using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class helthPlayer : MonoBehaviour
{

    public Slider hSlide;

    public void SetMaxPlayerHealth(int health)
    {

        hSlide.maxValue = health;
        hSlide.value = health;

    }

    public void SetHealth(int health)
    {

        hSlide.value = health;

    }

}
