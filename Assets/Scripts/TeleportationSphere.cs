using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationSphere : MonoBehaviour
{
    public void PerformTeleport()
    {
        FindObjectOfType<Player>().TeleportToSphere(this.transform);
    }
}
