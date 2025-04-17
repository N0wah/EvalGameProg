using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverUI;
    public TMPro.TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        Time.timeScale = 1;
        gameOverUI.SetActive(false);
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score : " + score;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
