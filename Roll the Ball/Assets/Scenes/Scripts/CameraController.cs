using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // set the distance between the camera and the player
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // move the camera when the player moves
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
