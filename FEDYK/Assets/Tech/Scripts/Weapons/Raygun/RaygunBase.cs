using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

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

    public void InstantiateRaycast(Vector3 startLoc, Camera playerCam)
    {
        //Code for raycasting, startLoc is the start of the ray
        //want to deduct ammo
        Debug.DrawRay(startLoc, playerCam.transform.forward * _range, Color.red);
        if (Physics.Raycast(startLoc, playerCam.transform.forward, out vision, _range))
        {
            if (vision.collider.tag == "Target")
            {
                Debug.Log(vision.collider.name + " is being shot");
                vision.collider.SendMessage("ApplyDamage", _damage);
            }
        }
    }
}
