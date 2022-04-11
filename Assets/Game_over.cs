using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_over : MonoBehaviour
{
   [SerializeField] GameObject Gameoverscreen;


    public void SetGameOver()
    {
        Gameoverscreen.SetActive(true);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
