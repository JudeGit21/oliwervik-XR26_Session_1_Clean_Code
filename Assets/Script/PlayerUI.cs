using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Slider healthBar;

    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private PlayerHealth playerHealth;

    private void Awake()
    {
        playerScore.OnScoreChanged += UpdateScore;
        playerHealth.OnHealthChanged += UpdateHealth;
    }

    private void Start()
    {
        healthBar.maxValue = playerHealth.MaxHealth;
        healthBar.value = playerHealth.MaxHealth;
    }

    private void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    private void UpdateHealth(float health)
    {
        healthBar.value = health;
    }
}