using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Controls : MonoBehaviour {

    public GameObject thePlayer;
    public bool isMoving;
    public bool isRunning;
    public float horizontalMove;
    public float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isRunning = true;
            }
            else 
            {
                isRunning = false;
            }
            isMoving = true;
            if (Input.GetKey(KeyCode.S))
            {
                thePlayer.GetComponent<Animator>().Play("WalkBack");
            }
            else
            {
                if (isRunning == false) // why double "=="??
                {
                    thePlayer.GetComponent<Animator>().Play("Walk");
                }
            else
                {
                    thePlayer.GetComponent<Animator>().Play("Run");

                }
            }
            if (isRunning == false)
            {   
                horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime *150;
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 4;
            }
            if (isRunning == true)
            {
                horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime *150;
                verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 10;
            }

            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);
        }
        else
        {
            isMoving= false;
            thePlayer.GetComponent<Animator>().Play("Idle1");
        }
    }
}
