using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class RotationUIButtons
{
    public Transform UIrotation;
    public Transform CameraRot;
    private Vector3 offset;

    public void CalculateOffSet()
    {
        offset = CameraRot.position - UIrotation.position;
    }
    public void GetRotation()
    {
        
        UIrotation.rotation = CameraRot.rotation;
        //UIrotation.LookAt(CameraRot);
        //Vector3 buttonPos = Camera.main.WorldToScreenPoint(UIrotation.position);
        //UIrotation.position = buttonPos;
        //Vector3 relativePos = CameraRot.position - UIrotation.position;
        //Quaternion rotation = Quaternion.LookRotation( offset, CameraRot.position);
        //UIrotation.rotation = rotation;
        //UIrotation.position = CameraRot.position - offset;

    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public  RotationUIButtons(Transform UIrotation, Transform CameraRot)
    {
        this.UIrotation = UIrotation;
        this.CameraRot = CameraRot;
    }
}
