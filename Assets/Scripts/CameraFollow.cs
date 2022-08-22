using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset, transform.position.y, transform.position.z);
    }
}
