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
    public GameObject[] g_goCannonBall;
    public AudioSource g_asCannonshot;

    private Vector3 g_vec3MovementVector;
    private Vector3 g_vec3DirectionalVector;

    public float g_fSpeed;
    public float g_fMaxspeed;
    public float g_fAccel;
    public float g_fRotationspeed;
    public int g_iPlayerNo;

    public bool g_bCanShoot;

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
            g_iJoystickNumber = g_iPlayerNo;
        }

        g_bCanShoot = true;
    }

    void shootTimer()
    {
        g_bCanShoot = true;
    }



    // Update is called once per frame
    void Update()
    {
        if (g_iJoystickNumber != 420)
        {
            switch (g_iJoystickNumber)
            {
               case 0: // player 1
                      {
                        if (Input.GetAxis("LeftY") < 0.1f && Input.GetAxis("LeftY") != 0.0f)  // ONLY POSITIVE MOVEMENT THUS THE BOAT CANNOT BE MANIPULATED BACKWARDS
                        {
                            transform.Translate(Vector3.back * 15 * Input.GetAxis("LeftY") * Time.deltaTime);
                        }

                        if (Input.GetAxis("L2") != 0.0f)
                        {
                            //fireCannon();
                        }

                        if (Input.GetAxis("RightX") > 0.1f || Input.GetAxis("RightX") < -0.1f) // CAMERA PIVOT
                        {
                            g_tPivotPoint[g_iJoystickNumber].position = g_goBoat[g_iJoystickNumber].transform.position;
                            g_tPivotPoint[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX") * Time.deltaTime);

                            g_goCannon[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX") * Time.deltaTime);

                        }

                        if (Input.GetAxis("LeftX") > 0.1f || Input.GetAxis("LeftX") < -0.1f)
                        {
                            g_goBoat[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("LeftX") * Time.deltaTime);
                        }

                        if (Input.GetButtonDown("AButton1") == true)
                        {
                            if (g_bCanShoot)
                            {
                                g_asCannonshot.Play();
                                Instantiate(g_goCannonBall[g_iJoystickNumber], g_goCannon[g_iJoystickNumber].transform.position, g_goCannon[g_iJoystickNumber].transform.rotation);
                                g_bCanShoot = false;
                                Invoke("shootTimer", 3);
                            }
                        }

                        break;
                      }

                  case 1:
                      {
                        if (Input.GetAxis("LeftY2") < 0.1 && Input.GetAxis("LeftY2") != 0)  // ONLY POSITIVE MOVEMENT THUS THE BOAT CANNOT BE MANIPULATED BACKWARDS
                        {
                            transform.Translate(Vector3.back * 15 * Input.GetAxis("LeftY2") * Time.deltaTime);
                        }


                        if (Input.GetAxis("L22") > 0)
                        {
                            //fireCannon();
                        }

                        if (Input.GetAxis("RightX2") > 0.1 || Input.GetAxis("RightX2") < -0.1) // CAMERA PIVOT
                        {
                            g_tPivotPoint[g_iJoystickNumber].position = g_goBoat[g_iJoystickNumber].transform.position;
                            g_tPivotPoint[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX2") * Time.deltaTime);

                            g_goCannon[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX2") * Time.deltaTime);

                        }

                        if (Input.GetAxis("LeftX2") > 0.1 || Input.GetAxis("LeftX2") < -0.1)
                        {
                            g_goBoat[g_iJoystickNumber].transform.Rotate(Vector3.up * 50 * Input.GetAxis("LeftX2") * Time.deltaTime);
                        }

                        //if (Input.GetAxis("R22") > 0.0f)
                        if (Input.GetButtonDown("AButton2") == true)
                        {
                            if (g_bCanShoot)
                            {
                                g_asCannonshot.Play();
                                Instantiate(g_goCannonBall[g_iJoystickNumber], g_goCannon[g_iJoystickNumber].transform.position, g_goCannon[g_iJoystickNumber].transform.rotation);
                                g_bCanShoot = false;
                                Invoke("shootTimer", 3);
                            }
                        }

                        break;
                      }
            }
        }
    }
}
