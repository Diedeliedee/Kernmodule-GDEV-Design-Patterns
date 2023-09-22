using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour, IHackable
{
    public void OnHit(int damamge)
    {
        Destroy(gameObject);
    }
}
