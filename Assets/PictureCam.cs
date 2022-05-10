using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PictureCam : MonoBehaviour
{
    private int screenshotCount = 0;
    string curScene;
    private RenderTexture img;
    private bool cam_on = false;

    public Camera PlayCam;
    GameObject canvas;
    GameObject UI_canv;
    GameObject FlashCam;

    string animal;

    private bool camFlash = false;
    public CanvasGroup cameraArea;

    void Start()
    {
        curScene = SceneManager.GetActiveScene().name;
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        UI_canv = GameObject.FindGameObjectWithTag("Main_UI");

        canvas.SetActive(false);
        UI_canv.SetActive(true);

    }


    void Update()
    {
        // take screenshot when c is pressed
        // set to switch camera when c is pressed, then only take picture when camera mode = true and space = pressed
        if (Input.GetKeyDown("c"))
        {
            if (cam_on == false)
            {
                cam_on = true;
                Debug.Log(cam_on);

                // show overlay when true
                canvas.SetActive(true);
                UI_canv.SetActive(false);

            }
            else
            {
                cam_on = false;
                Debug.Log(cam_on);

                // hide overlay when false
                canvas.SetActive(false);
                UI_canv.SetActive(true);

            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cam_on == true)
            {
                string screenshotFilename;
                do
                {
                    curScene = SceneManager.GetActiveScene().name;

                    screenshotCount++;

                    animal = gameObject.GetComponent<LineOfSight>().animal_name;
                    screenshotFilename = animal + " photo " + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".png";

                } while (File.Exists(screenshotFilename));


                string folderPath = Directory.GetCurrentDirectory() + "/Screenshots/" + curScene + "/";
                if (!Directory.Exists(folderPath)){
                    Directory.CreateDirectory(folderPath);
                }

                ScreenCapture.CaptureScreenshot(Path.Combine(folderPath, screenshotFilename));
                StartCoroutine(CameraWait());


            }
        }

        if (Input.GetKeyDown("g"))
        {
            curScene = SceneManager.GetActiveScene().name;

            if (curScene != "NatureCenter")
            {
                SceneManager.LoadScene("NatureCenter");
            }
        }

        if (camFlash)
        {
            cameraArea.alpha = cameraArea.alpha - Time.deltaTime;
            if (cameraArea.alpha <= 0)
            {
                cameraArea.alpha = 0;
                camFlash = false;
            }
        }
    }

    public void pictureTake()
    {
        camFlash = true;
        cameraArea.alpha = 1;
    }


    IEnumerator CameraWait()
    {

        yield return new WaitForSeconds(1.5f);

        Debug.Log("screenshot taken");
        pictureTake();

    }

}

