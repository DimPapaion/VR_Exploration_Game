using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class LinearMovement
{
    public Transform rig;
    public float speed = 0;
    public Transform mainCamera;
    public float playerHeight = 1.70f;


    public void SetSpeed(float value)
    {
        speed = value;
    }


    public void Move()
    {
        rig.position += mainCamera.rotation * Vector3.forward * speed;
        rig.position = new Vector3(rig.position.x, playerHeight, rig.position.z);
    }

    public LinearMovement(Transform rig, Transform mainCamera)
    {
        this.rig = rig;
        this.mainCamera = mainCamera;
    }

}
