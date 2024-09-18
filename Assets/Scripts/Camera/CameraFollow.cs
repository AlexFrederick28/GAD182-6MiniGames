using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraPosition;

    public float moveSpeed;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        cameraPosition = playerTransform.position - transform.position;
        cameraPosition.z = -7.5f;

        if (cameraPosition.magnitude > 5)
        {
            cameraPosition = cameraPosition.normalized;
            transform.position += cameraPosition * moveSpeed * Time.deltaTime;
        }

        

        


    }
}
