using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author - Benjamin Edwards
 * Date Created - 13/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class Settings : MonoBehaviour
{
    private float _fov = 90;
	//// Use this for initialization
	//void Start ()
 //   {
		
	//}
	
	//// Update is called once per frame
	//void Update ()
 //   {
		
	//}

    public float FOV
    {
        get
        {
            return _fov;
        }

        set
        {
            _fov = value;
        }
    }
}
