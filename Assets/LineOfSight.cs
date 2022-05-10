using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour {

    private RaycastHit vision;
    public float rayLength;
    public string animal_name;

    void Start () {

    }
	
	void Update () {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rayLength, Color.red, 0.5f);

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength))
        {
            if (vision.collider.tag == "Animal")
            {
                Debug.Log(vision.collider.name);
                animal_name = vision.collider.name;
            }
            else
            {
                animal_name = "none";
            }
        }

    }
}
