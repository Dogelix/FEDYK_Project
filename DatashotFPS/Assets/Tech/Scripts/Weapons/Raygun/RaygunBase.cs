using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*
 * Author - Benjamin Edwards
 * Date Created - 14/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class RaygunBase : NetworkBehaviour
{
    protected int _ammoCount = 0;
    protected int _damage = 0;
    protected float _range = 0;

    private RaycastHit vision;

    public int AmmoCount
    {
        get
        {
            return _ammoCount;
        }
        set
        {
            _ammoCount = value;
        }
    }

    public int Damage
    {
        get
        {
            return _damage;
        }
        set
        {
            _damage = value;
        }
    }

    public void InstantiateRaycast(Vector3 startLoc, Vector3 playerCam)
    {
        //Code for raycasting, startLoc is the start of the ray
        //want to deduct ammo
        Debug.DrawRay(startLoc, playerCam * _range, Color.red);
        if (Physics.Raycast(startLoc, playerCam, out vision, _range))
        {
            if (vision.collider.tag == "Target")
            {
                Debug.Log(vision.collider.name + " is being shot");
                vision.collider.GetComponent<TargetHealth>().ApplyTargetDamage(_damage);
            }
            if (vision.collider.tag == "Player")
            {
                Debug.Log("A player is being shot");
                vision.collider.GetComponent<PlayerFunctions>().ApplyPlayerDamage(_damage);
            }
        }
    }
}
