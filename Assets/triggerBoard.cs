using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBoard : MonoBehaviour {

    GameObject boardtxt;
    GameObject UI_canv;

    void Start () {
        boardtxt = GameObject.FindGameObjectWithTag("Images");
        UI_canv = GameObject.FindGameObjectWithTag("Main_UI");
        boardtxt.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("At board");
        UI_canv.SetActive(false);
        boardtxt.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Left board");
        UI_canv.SetActive(true);
        boardtxt.SetActive(false);
    }
}
