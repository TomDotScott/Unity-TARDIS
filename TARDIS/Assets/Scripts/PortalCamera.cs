using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform tardis;
    public Transform otherTardis;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffsetFromTardis = playerCamera.position - otherTardis.position;
        transform.position = tardis.position + playerOffsetFromTardis;

        float angularDifference = Quaternion.Angle(tardis.rotation, otherTardis.rotation);

        Quaternion rotationalDifference = Quaternion.AngleAxis(angularDifference, Vector3.up);
        Vector3 newCameraDirection = rotationalDifference * playerCamera.forward;

        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
