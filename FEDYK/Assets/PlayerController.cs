//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class PlayerController : MonoBehaviour
{
	void Update ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //transform.Rotate(0, x, z);
        transform.Translate(x, 0, z);
	}
}
