using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AWeaponDecorator
{
    private AWeaponDecorator wrappee = null;

    public AWeaponDecorator(AWeaponDecorator wrappee)
    {
        this.wrappee = wrappee;
    }

    public abstract void Hit(out IDamagable hitObject);
}
