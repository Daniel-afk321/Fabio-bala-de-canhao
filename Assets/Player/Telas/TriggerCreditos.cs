using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCreditos : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            SceneManager.LoadScene("Creditos");
        }
    }
}
