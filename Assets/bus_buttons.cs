using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bus_buttons : MonoBehaviour {

    public void VisitField()
    {
        Debug.Log("Tutorial Field");
        SceneManager.LoadScene("TutorialField");
    }

    public void VisitPlains()
    {
        Debug.Log("Plains");
        SceneManager.LoadScene("Plains");
    }

    public void VisitCenter()
    {
        Debug.Log("Center");
        SceneManager.LoadScene("NatureCenter");
    }

    public void VisitVolcano()
    {
        Debug.Log("Volcano");
        SceneManager.LoadScene("Volcano");
    }

}
