using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerDoor : MonoBehaviour {

    GameObject bustxt;
    GameObject UI_canv;

    void Start()
    {
        bustxt = GameObject.FindGameObjectWithTag("Bus");
        UI_canv = GameObject.FindGameObjectWithTag("Main_UI");
        bustxt.SetActive(false);
    }

	void OnTriggerStay(Collider other)
    {
        bustxt.SetActive(true);
        UI_canv.SetActive(false);
        Debug.Log("At Doorway");
    }

    void OnTriggerExit(Collider other)
    {
        bustxt.SetActive(false);
        UI_canv.SetActive(true);
    }
}
