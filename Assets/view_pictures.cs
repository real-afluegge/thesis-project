using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class view_pictures : MonoBehaviour {

	public void openFolder () {
        Application.OpenURL(Directory.GetCurrentDirectory() + "/Screenshots/");
        Debug.Log("open folder");
    }
	
}
