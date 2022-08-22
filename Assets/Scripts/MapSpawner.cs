using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public GameObject floor;
    public int offset;
    public Transform storage;
    string[] colors = new string[] { "6ded8a", "1645f5", "ff5f85", "ed3833" };
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Ground"))
        {
            GameObject floorpiece = Instantiate(floor) as GameObject;
            floorpiece.transform.position = new Vector3(transform.position.x + offset, -5, 0);
            floorpiece.transform.SetParent(storage);
        }
    }
    public void ClearStorage()
    {
        for (int i = 0; i < storage.childCount; i++)
        {
            Destroy(storage.GetChild(i).gameObject);
        }
    }
}
