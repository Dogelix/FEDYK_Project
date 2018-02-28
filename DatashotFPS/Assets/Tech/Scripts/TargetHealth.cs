using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*
 * Author - Benjamin Edwards
 * Date Created - 14/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class TargetHealth : NetworkBehaviour
{
    [SyncVar]
    private int health = 20;

    public void ApplyTargetDamage(int damage)
    {
        if (isServer)
        {
            health -= damage;
            Debug.Log(health);
            if (health <= 0)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
}
