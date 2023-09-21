using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private float range;
    [Space]
    [SerializeField] private Transform source;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && HitSomething(out IShootable iShootable))
        {
            iShootable.Hit(10);
        }
        if (Input.GetMouseButtonDown(1) && HitSomething(out IHackable iHackable))
        {
            iHackable.Hit(10);
        }
    }

    bool HitSomething<T>(out T hit)
    {
        hit = default;

        if (!Physics.Raycast(source.position, source.forward, out RaycastHit raycastHit, range)) return false;
        if (!raycastHit.transform.TryGetComponent(out hit)) return false;
        return true;
    }
}
