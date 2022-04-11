using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject botao_reiniciar;
    public GameObject botao_sair;
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        /*
        Time.timeScale = 1;
        botao_reiniciar.SetActive(true);
        botao_sair.SetActive(true);
        */
    }
/*
    public void reiniciarcena() 
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
        botao_reiniciar.SetActive(false);
        botao_sair.SetActive(false);
    }

    public void saicena()
    {
        Time.timeScale = 1;
        botao_reiniciar.SetActive(false);
        botao_sair.SetActive(false);
        Application.Quit();
    }
*/
}
