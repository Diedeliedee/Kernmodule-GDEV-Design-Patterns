using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class responsible for feedback via the observer pattern.
/// </summary>
public class HitReader : MonoBehaviour, IServiceItem
{
    private void Start()
    {
        var eventManager = (EventManager)ServiceLocator.Instance.Get("Events");

        eventManager.Subscribe("OnRockHit", ReactToRockHit);
        eventManager.Subscribe("OnEnemyHit", ReactToEnemyHit);
    }

    private void ReactToRockHit()
    {
        Debug.Log("The rock has been hit!!");
    }

    private void ReactToEnemyHit()
    {
        Debug.Log("The enemy has been hit!!");
    }
}
