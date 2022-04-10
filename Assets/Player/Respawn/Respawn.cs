using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform RespawnPoint;

    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = RespawnPoint.transform.position;
        other.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

}
