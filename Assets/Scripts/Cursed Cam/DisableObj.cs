using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObj : MonoBehaviour
{

    public GameObject objectDisable;


    void OnTriggerEnter()
    {
        new WaitForSeconds(1);
        objectDisable.SetActive(false);
    }


    void OnTriggerExit()
    {
        new WaitForSeconds(1);
        objectDisable.SetActive(false);
    }
}