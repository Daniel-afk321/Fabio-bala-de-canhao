using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game2 : MonoBehaviour
{
    [SerializeField] Game_over gameOverManager;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("M"))
        {
            gameOverManager.SetGameOver();
            //Destroy(gameObject);
        }
    }
}
