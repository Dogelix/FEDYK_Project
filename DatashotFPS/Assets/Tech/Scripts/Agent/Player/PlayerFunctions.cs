using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class PlayerFunctions : NetworkBehaviour
{
    [SerializeField]
    private int _health = 100;
    [SerializeField]
    private int _armour = 50;
    [SerializeField]
    private string _username = "Joe Bloggs";

    private Vector3 _spawnPoint;

    void Start ()
    {
        if (isLocalPlayer)
        {
            _spawnPoint = transform.position;
        }
    }

    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
        }
    }

    public int Armour
    {
        get
        {
            return _armour;
        }

        set
        {
            _armour = value;
        }
    }

    public string UserName
    {
        get
        {
            return _username;
        }
        set
        {
            _username = value;
        }
    }

    public void ApplyPlayerDamage(int damage)
    {
        _health -= damage;
        Debug.Log(_health);
        if (_health <= 0)
        {
            Rpc_Respawn();
        }
    }

    [ClientRpc]
    void Rpc_Respawn()
    {
        //if (isLocalPlayer)
        //{
            _health = 100;
            transform.position = _spawnPoint;
        //}
    }
}
