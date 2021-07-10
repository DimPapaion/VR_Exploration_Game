using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class SnapToGround : MonoBehaviour
{
    /*
    [MenuItem("Custom/Snap to Ground %g")]

    public static void Ground()
    {
        foreach(var transform in Selection.transforms)
        {
            RaycastHit hitInfo;
            var hits = Physics.RaycastAll(transform.position + Vector3.up, Vector3.down,50f);
            foreach (var hit in hits)
            {
                if (hit.collider.gameObject == transform.gameObject)
                    continue;
                transform.position = hit.point;
                break;
            }

        }
    }
    */
}
