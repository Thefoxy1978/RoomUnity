using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public Transform TeleportTarget;
    public Gameobject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = TeleportTarget.transform.position;
    }

}