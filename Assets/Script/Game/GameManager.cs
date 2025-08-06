using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    private float gameTime = 0f;

    [SerializeField] private TextMeshProUGUI gameStatusText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject gameOverPanel;

    private void Start()
    {
        gameStatusText.text = "Game Started!";
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        if (gameOver) return;

        gameTime += Time.deltaTime;
        timerText.text = $"Time: {Mathf.FloorToInt(gameTime)}s";

        if (Input.GetKeyDown(KeyCode.R))
            RestartGame();
    }

    public void GameOver()
    {
        gameOver = true;
        gameStatusText.text = "GAME OVER!";
        gameOverPanel.SetActive(true);
        Invoke(nameof(RestartGame), 2f);
    }

    public void WinGame()
    {
        gameOver = true;
        var score = FindObjectOfType<PlayerScore>()?.Score ?? 0;
        gameStatusText.text = $"YOU WIN! Score: {score}";
        Invoke(nameof(RestartGame), 2f);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}