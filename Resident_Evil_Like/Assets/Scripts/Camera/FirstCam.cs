using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCam : MonoBehaviour
{
    public GameObject cameraOne;
    public GameObject cameraTwo;
    public bool cameraOn = false;
    public int cameraNumber;  

    void Start()
    {
        cameraNumber = 1;
        StartCoroutine(CameraSwitch());
    }

    IEnumerator CameraSwitch () 
    {
        yield return new WaitForSeconds (5);
        cameraTwo.SetActive(true);
        cameraOne.SetActive(false);
        cameraOn = true; 
        cameraNumber = 2;
    } 


}
