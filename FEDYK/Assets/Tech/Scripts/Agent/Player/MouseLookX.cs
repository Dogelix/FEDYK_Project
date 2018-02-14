using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class MouseLookX : NetworkBehaviour
{
    public float speedFactor;
    private float x;
    private Vector3 lookRotation = Vector3.zero;

    void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        x = Input.GetAxis("Camera X");
        lookRotation = new Vector3(0, (x * -1) * speedFactor, 0);
        transform.eulerAngles = transform.eulerAngles - lookRotation;
    }
}
