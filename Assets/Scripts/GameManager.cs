using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject loseInterface;

    public static bool youWin;
    public GameObject winInterface;

    private void Awake()
    {
        gameOver = false;
        youWin = false;
    }

    private void Update()
    {
        if (gameOver)
        {
            loseInterface.SetActive(true);
        }

        if (youWin)
        {
            winInterface.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}