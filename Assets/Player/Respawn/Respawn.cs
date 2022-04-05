using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Player jogador;
    [SerializeField] private Transform RespawnPoint;

    void Start()
    {
        jogador = GetComponent<Player>();
    }

    void OnCollisionEnter(Collision collision)
    {
        jogador.transform.position = RespawnPoint.transform.position;

    }

}
