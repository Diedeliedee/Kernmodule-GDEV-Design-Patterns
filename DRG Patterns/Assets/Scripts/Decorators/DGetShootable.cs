using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DGetShootable : AWeaponDecorator
{
    private Transform source = null;

    public DGetShootable(Transform source, AWeaponDecorator wrappee) : base(wrappee)
    {
        this.source = source;
    }

    public override void Execute(IDamagable hitObject)
    {
        if (!Physics.Raycast(source.position, source.forward, out RaycastHit raycastHit, 10f)) return;
        if (!raycastHit.transform.TryGetComponent(out IShootable hit)) return;

        wrappee?.Execute(hit);
    }
}
