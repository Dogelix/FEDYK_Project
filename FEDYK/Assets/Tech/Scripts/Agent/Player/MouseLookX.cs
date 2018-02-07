using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class MouseLookX : MonoBehaviour
{
    private float x;
    private Vector3 lookRotation = Vector3.zero;

    void Update ()
    {
        x = Input.GetAxis("Mouse X");
        lookRotation = new Vector3(0, x * -1, 0);
        transform.eulerAngles = transform.eulerAngles - lookRotation;
    }
}
