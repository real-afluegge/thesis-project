using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonThroughKeys : MonoBehaviour {

    public string key;
	
	void Update () {
        if (Input.GetKeyDown(key))
        {
            EventSystem.current.SetSelectedGameObject(this.gameObject);
        }
    }
}
