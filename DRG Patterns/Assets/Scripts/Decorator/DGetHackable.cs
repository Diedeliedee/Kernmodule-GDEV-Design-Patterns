using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DGetHackable : AWeaponDecorator
{
    private Transform source = null;

    public DGetHackable(Transform source, AWeaponDecorator wrappee) : base(wrappee)
    {
        this.source = source;
    }

    public override void Execute(IDamagable hitObject)
    {
        if (!Physics.Raycast(source.position, source.forward, out RaycastHit raycastHit, 3f)) return;
        if (!raycastHit.transform.TryGetComponent(out IHackable hit)) return;

        wrappee?.Execute(hit);
    }
}
