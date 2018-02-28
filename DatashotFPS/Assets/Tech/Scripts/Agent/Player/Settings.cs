using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author - Benjamin Edwards, Jake Yeatman
 * Date Created - 13/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class Settings : MonoBehaviour
{
    private float _fov = 90;
    private Camera _camera = null;

    private void Start()
    {
        _camera = gameObject.GetComponent<Camera>();
        _camera.fieldOfView = _fov;
    }

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
