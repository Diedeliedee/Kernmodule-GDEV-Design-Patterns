using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickaxeContext : WeaponBase
{
    [SerializeField] private int damage;
    [Space]
    [SerializeField] private Transform hitRayOrigin;

    private AWeaponDecorator decorator = null;

    private void Awake()
    {
        decorator = new DGetHackable(hitRayOrigin, new DApplyDamage(damage, null));
    }

    public override void Fire()
    {
        decorator.Execute(null);
    }
}
