using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireCommand : ICommand
{
    public event Action onExecute = null;

    private WeaponBase weapon = null;

    public FireCommand(WeaponBase weapon)
    {
        this.weapon = weapon;
    }

    public ICommand Execute()
    {
        weapon.Fire();
        onExecute?.Invoke();
        return this;
    }
}