using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffset = new Vector3(x: playerCamera.position.x * 2 - otherPortal.position.x * 2,
                                           y: playerCamera.position.y * 2 - otherPortal.position.y * 2,
                                           z: playerCamera.position.z * 2 - otherPortal.position.z * 2);

        transform.position = new Vector3(x: portal.position.x + playerOffset.x,
                                         y: portal.position.y,
                                         z: portal.position.z + playerOffset.z);

    }
}
