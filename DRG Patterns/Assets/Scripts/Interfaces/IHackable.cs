using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHackable : IDamagable
{
    new public void Hit(int damage);
}
