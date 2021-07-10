using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class Teleportation
{
    public Transform transformToTeleport;

    public void Teleport(Transform spherePos)
    {
        transformToTeleport.position = spherePos.position;
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public Teleportation(Transform transformToTeleport)
    {
        this.transformToTeleport = transformToTeleport;
    }
}
