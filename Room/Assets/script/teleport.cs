using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour
{
    public GameObject traget;
    public Transform player;

        void OnTriggerEnter(Collider other)
        {
            player.transform.position = traget.transform.position;
        }

}