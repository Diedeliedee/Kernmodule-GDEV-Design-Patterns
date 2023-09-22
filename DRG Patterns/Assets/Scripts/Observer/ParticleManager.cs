using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour, IServiceItem
{
    private void Start()
    {
        var eventManager = (EventManager)ServiceLocator.Instance.Get("Events");

        eventManager.Subscribe("OnRockHit", SpawnParticle);
        eventManager.Subscribe("OnEnemyHit", SpawnParticle);
    }

    private void SpawnParticle()
    {
        Debug.Log("Yippeee!!!");
    }
}
