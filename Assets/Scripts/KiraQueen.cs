using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiraQueen : MonoBehaviour
{

    public GameObject kiravid;

    void Start()
    {

        kiravid.SetActive(true);
        StartCoroutine(introCut());

    }

    IEnumerator introCut()
    {

        yield return new WaitForSeconds(23f);
        Destroy(kiravid.gameObject);

    }

}
