using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    private int health = 20;
    void ApplyDamage(int damage)
    {
        health -= damage;
        Debug.Log(health);
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
