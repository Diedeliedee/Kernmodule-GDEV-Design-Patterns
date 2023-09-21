using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseRangeDecorator : AWeaponDecorator
{
    private Transform source = null;

    public CloseRangeDecorator(Transform source, AWeaponDecorator wrappee) : base(wrappee)
    {
        this.source = source
    }

    public override void Hit(out IDamagable hitObject)
    {
        hitObject = default;
        if (!Physics.Raycast(source.position, source.forward, out RaycastHit raycastHit, 3f)) return;
        if (!raycastHit.transform.TryGetComponent(out IHackable hit)) return;
    }
}
