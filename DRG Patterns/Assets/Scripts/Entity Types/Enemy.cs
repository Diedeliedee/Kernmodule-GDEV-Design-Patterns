using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHackable, IShootable
{
    public void Hit(int damage)
    {
        Destroy(gameObject);
    }
}
