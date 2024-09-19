using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraPosition;

    public float moveSpeed;
    public float cameraFar;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 followCam = new Vector3(playerTransform.position.x, playerTransform.position.y, -7.5f);

        cameraPosition = followCam - transform.position;

        if (cameraPosition.magnitude > 0 && cameraPosition.magnitude < 1)
        {
            cameraPosition = cameraPosition.normalized;
            transform.position += cameraPosition * moveSpeed * Time.deltaTime;

        }
        if (cameraPosition.magnitude > 1)
        {
            cameraPosition = cameraPosition.normalized;
            transform.position += cameraPosition * cameraFar * Time.deltaTime;

        }






    }
}
