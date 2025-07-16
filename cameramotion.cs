using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cameracontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    private Vector3 offset;
    //store the offset between the camera and the player

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = offset + player.transform.position;
    }
}