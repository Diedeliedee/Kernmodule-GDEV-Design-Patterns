using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private WeaponBase gun;
    [SerializeField] private WeaponBase pickaxe;

    private State state = default;

    private void Start()
    {
        //  Adding commands to the input handler.
        var inputHandler = (InputHandler)ServiceLocator.Instance.Get("Input");

        inputHandler.AddCommand(LeftMouseButtonPressed, new FireCommand(gun));
        inputHandler.AddCommand(RightMouseButtonPressed, new FireCommand(pickaxe));

        state = State.HOLSTERGUN;
        pickaxe.Deactivate();
    }

    private void Update()
    {
        switch (state)
        {
            case State.HOLSTERGUN:
                if (Input.GetMouseButtonDown(0))
                {
                    gun.Fire();
                }
                if (Input.GetMouseButtonDown(1))
                {
                    pickaxe.Fire();

                    pickaxe.Activate();
                    gun.Deactivate();

                    state = State.HOLSTERPICKAXE;
                }
                break;

            case State.HOLSTERPICKAXE:
                if (Input.GetMouseButtonUp(1))
                {
                    pickaxe.Deactivate();
                    gun.Activate();

                    state = State.HOLSTERGUN;
                }
                break;
        }
    }

    private bool LeftMouseButtonPressed() => Input.GetMouseButtonDown(0);
    private bool RightMouseButtonPressed() => Input.GetMouseButtonDown(1);

    private enum State
    {
        HOLSTERGUN,
        HOLSTERPICKAXE,
    }
}
