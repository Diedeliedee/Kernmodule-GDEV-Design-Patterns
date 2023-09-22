using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DApplyDamage : AWeaponDecorator
{
    private int damage = 0;

    public DApplyDamage(int damage, AWeaponDecorator wrappee) : base(wrappee)
    {
        this.damage = damage;
    }

    public override void Execute(IDamagable hitObject)
    {
        hitObject.OnHit(damage);

        wrappee?.Execute(hitObject);
    }
}
