using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    public GameObject player;
    public Transform reciever;
    private bool overlappingPlayer = false;

    private void LateUpdate()
    {
        if (overlappingPlayer)
        {
            player.GetComponent<CharacterController>().enabled = false;
            Vector3 portalToPlayer = player.transform.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
            if (dotProduct < 0)
            {
                float rotationDifference = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDifference += 180;
                player.transform.Rotate(Vector3.up, rotationDifference);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDifference, 0f) * portalToPlayer;
                player.transform.position = reciever.position + positionOffset;
                overlappingPlayer = false;
            }
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
  

    private void OnTriggerEnter(Collider other)
    {
        overlappingPlayer = true;
        Debug.Log("OVERLAPPING!" + overlappingPlayer);

    }

    private void OnTriggerExit(Collider other)
    {
        overlappingPlayer = false;
        Debug.Log("NOT OVERLAPPING ANY MORE" + overlappingPlayer);
    }
}
