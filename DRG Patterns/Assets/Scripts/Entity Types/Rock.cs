using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour, IHackable
{
    public void Hit(int damamge)
    {
        Destroy(gameObject);
    }
}
