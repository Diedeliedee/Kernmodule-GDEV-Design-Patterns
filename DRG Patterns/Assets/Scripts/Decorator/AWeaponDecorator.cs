using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AWeaponDecorator
{
    protected AWeaponDecorator wrappee = null;

    public AWeaponDecorator(AWeaponDecorator wrappee)
    {
        this.wrappee = wrappee;
    }

    public abstract void Execute(IDamagable hitObject);
}
