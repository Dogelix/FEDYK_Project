using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class MouseLookY : MonoBehaviour
{
    private float y;
    private float lowLimit = 80;
    private float highLimit = 280;
    private Vector3 lookRotation = Vector3.zero;

    void Update()
    {
        y = Input.GetAxis("Mouse Y");
        lookRotation = new Vector3(y, 0, 0);
        transform.eulerAngles = transform.eulerAngles - lookRotation;
        if (transform.eulerAngles.x > lowLimit && transform.eulerAngles.x < lowLimit + 180)
        {
            transform.eulerAngles = new Vector3(lowLimit, transform.eulerAngles.y, 0);
        }
        if (transform.eulerAngles.x < highLimit && transform.eulerAngles.x > highLimit - 180)
        {
            transform.eulerAngles = new Vector3(highLimit, transform.eulerAngles.y, 0);
        }
    }
}