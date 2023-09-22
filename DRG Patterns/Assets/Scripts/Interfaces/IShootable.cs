using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable : IDamagable
{
    new public void OnHit(int damage);
}
