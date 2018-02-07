using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author - Benjamin Edwards
 * Date Created - 07/02/2018
 * Copyright - FEDYK : Games 2018
 */

public class PlayerFunctions : MonoBehaviour
{
    [SerializeField]
    private int _health = 100;
    [SerializeField]
    private int _armour = 50;
    [SerializeField]
    private string _username = "Joe Bloggs";
	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
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
}
