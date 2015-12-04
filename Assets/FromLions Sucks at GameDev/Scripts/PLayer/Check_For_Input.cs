﻿using UnityEngine;
using System.Collections;

public class Check_For_Input : MonoBehaviour {


	// Use this for initialization
	void Start () {

        InvokeRepeating("GetInput", 0f, .001f);
	
	}
	
	// Update is called once per frame
	public void GetInput()
    {
       if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            gameObject.GetComponent<Move_To_Click>().Camera.GetComponent<Click_To_Move>().GetDestination();
            gameObject.GetComponent<Move_To_Click>().Update_NavMesh_Destination();
       }


      if (Input.GetKeyDown(KeyCode.Mouse0))
      {
           gameObject.GetComponent<Move_To_Click>().Camera.GetComponent<Click_To_Target>().GetTarget();
      }


      if (Input.GetAxisRaw("Mouse ScrollWheel") < 0)
       {
            ++gameObject.GetComponent<Move_To_Click>().Camera.GetComponent<Smooth_Camera_Follow>().Camera_Height;
        }

        if (Input.GetAxisRaw("Mouse ScrollWheel") > 0)
        {
            --gameObject.GetComponent<Move_To_Click>().Camera.GetComponent<Smooth_Camera_Follow>().Camera_Height;
        }

        gameObject.GetComponent<Move_To_Click>().Camera.GetComponent<Click_To_Target>().MouseOverTarget();

    }
}
