using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private WeaponBase gun;
    [SerializeField] private WeaponBase pickaxe;

    private FireCommand fireGun = null;
    private FireCommand usePick = null;

    private InputHandler inputHandler = null;

    private void Start()
    {
        //  Adding commands to the input handler.
        inputHandler = (InputHandler)ServiceLocator.Instance.Get("Input");

        fireGun = new FireCommand(gun);
        usePick = new FireCommand(pickaxe);

        inputHandler.AddCommand(LeftMouseButtonPressed, fireGun);
        inputHandler.AddCommand(RightMouseButtonPressed, usePick);

        //  Subscribing to command events.
        fireGun.onExecute += OnGunFired;
        usePick.onExecute += OnPickAxed;

        //  Setting state.
        pickaxe.Deactivate();
    }

    private void Update()
    {
        inputHandler.HandleInput();
    }

    private bool LeftMouseButtonPressed() => Input.GetMouseButtonDown(0);
    private bool RightMouseButtonPressed() => Input.GetMouseButtonDown(1);

    private void OnGunFired()
    {
        pickaxe.Deactivate();
        gun.Activate();
    }

    private void OnPickAxed()
    {
        gun.Deactivate();
        pickaxe.Activate();
    }
}
