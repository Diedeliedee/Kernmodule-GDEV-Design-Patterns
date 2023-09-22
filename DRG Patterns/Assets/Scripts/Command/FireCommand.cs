using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireCommand : ICommand
{
    WeaponBase weapon = null;

    public FireCommand(WeaponBase weapon)
    {
        this.weapon = weapon;
    }

    public ICommand Execute()
    {
        weapon.Fire();
        return this;
    }
}