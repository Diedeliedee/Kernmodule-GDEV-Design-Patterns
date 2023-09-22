using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHackable, IShootable
{
    public void OnHit(int damage)
    {
        Destroy(gameObject);
    }
}
