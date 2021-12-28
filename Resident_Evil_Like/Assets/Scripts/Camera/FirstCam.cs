using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCam : MonoBehaviour
{
    public GameObject cameraOn;
    public GameObject cameraOff;
    public bool camOn = false;
    public int cameraNumber;  

    void Start()
    {
        cameraNumber = 1;
        //StartCoroutine(CameraSwitch());
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cameraOn.SetActive(true);
            cameraOff.SetActive(false);
        }
    }
}
