//
// Bachelor of Software Engineering
// Media Design School
// Auckland
// New Zealand
//
// (c) 2018 Media Design School.
//
// File Name	: playerController.cs
// Description	: Handles the input from multiple controllers and applies due effects to respective character in the game world
// Author		: Benjamin Pointer
// Mail			: Benjamin.Pointer@mediadesign.school.nz
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject[] g_goBoat;
    public GameObject[] g_goCannon;
    public Transform[] g_tPivotPoint;
    public Camera[] g_cActiveCameras;

    private Vector3 g_vec3MovementVector;
    private Vector3 g_vec3DirectionalVector;

    public float g_fSpeed;
    public float g_fMaxspeed;
    public float g_fAccel;
    public float g_fRotationspeed;
    public int g_iPlayerNo;

    public int g_iJoystickNumber;

    string[] g_sarrControllerID;

    // Use this for initialization
    void Start()
    {
        g_fSpeed = 0;
        g_fMaxspeed = 10;

        g_iJoystickNumber = 420;

        g_sarrControllerID = Input.GetJoystickNames();
        if (Input.GetJoystickNames().Length > 0)
        {
            print("Controller Connected");
            print(g_sarrControllerID[g_iPlayerNo]);
            g_iJoystickNumber = g_iPlayerNo;
        }
    }


    void fireCannon()
    {

    }

   /* void PushPlayerMovement(Vector3 _newPos)
    {
        //characterController[g_iJoystickNumber].Move(_newPos * Time.deltaTime);
        g_goBoat[g_iJoystickNumber].transform.Translate(_newPos * Time.deltaTime);
        return;
    }*/


    // Update is called once per frame
    void Update()
    {
        if (g_iJoystickNumber != 420)
        {
            switch (g_iJoystickNumber)
              {
                  case 0: // player 1
                      {
                        if (Input.GetAxis("LeftY") < 0.1 && Input.GetAxis("LeftY") != 0)  // ONLY POSITIVE MOVEMENT THUS THE BOAT CANNOT BE MANIPULATED BACKWARDS
                        {
                            transform.Translate(Vector3.back * 15 * Input.GetAxis("LeftY") * Time.deltaTime);
                            print("moving ship");
                        }

                        if (Input.GetAxis("L2") > 0)
                        {
                            //moveShip(g_iJoystickNumber);
                            print("firing cannon");
                            fireCannon();
                        }

                        if (Input.GetAxis("RightX") > 0.1 || Input.GetAxis("RightX") < -0.1) // CAMERA PIVOT
                        {
                            g_tPivotPoint[g_iJoystickNumber].position = g_goBoat[g_iJoystickNumber].transform.position;
                            g_tPivotPoint[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX") * Time.deltaTime);
                            print("cam pivot point altered");
                            g_goCannon[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX") * Time.deltaTime);

                        }

                        if (Input.GetAxis("LeftX") > 0.1 || Input.GetAxis("LeftX") < -0.1)
                        {
                            g_goBoat[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("LeftX") * Time.deltaTime);
                            print("boat pos altered");
                        }

                        break;
                      }

                  case 1:
                      {
                        if (Input.GetAxis("LeftY2") < 0.1 && Input.GetAxis("LeftY2") != 0)  // ONLY POSITIVE MOVEMENT THUS THE BOAT CANNOT BE MANIPULATED BACKWARDS
                        {
                            transform.Translate(Vector3.back * 15 * Input.GetAxis("LeftY2") * Time.deltaTime);
                            print("moving ship2");
                        }


                        if (Input.GetAxis("L22") > 0)
                        {
                            //moveShip(g_iJoystickNumber);
                            print("firing cannon2");
                            fireCannon();
                        }

                        if (Input.GetAxis("RightX2") > 0.1 || Input.GetAxis("RightX2") < -0.1) // CAMERA PIVOT
                        {
                            // moveShip(g_iJoystickNumber);
                            g_tPivotPoint[g_iJoystickNumber].position = g_goBoat[g_iJoystickNumber].transform.position;
                            g_tPivotPoint[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX2") * Time.deltaTime);
                            print("cam pivot point altered2");
                            g_goCannon[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX2") * Time.deltaTime);

                        }

                        if (Input.GetAxis("LeftX2") > 0.1 || Input.GetAxis("LeftX2") < -0.1)
                        {
                            g_goBoat[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("LeftX2") * Time.deltaTime);
                            print("boat pos altered2");
                        }

                        break;
                      }
              }
          
          //  this.transform.Translate(0, 0, g_fSpeed * Time.deltaTime);
        }
        else
        {
            print("fuckity fuck fuck");
        }



        //transform.Rotate(Vector3.down * -g_fRotationspeed * Input.GetAxis("LeftX") * Time.deltaTime);


        //transform.Translate(0,0,g_fSpeed * Time.deltaTime);
    }
}
