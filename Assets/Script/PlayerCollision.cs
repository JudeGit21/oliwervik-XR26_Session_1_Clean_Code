using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerScore playerScore;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private GameManager gameManager;

    private void Awake()
    {
        if (playerHealth != null)
            playerHealth.OnPlayerDied += HandlePlayerDeath;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            playerScore.AddScore(10);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth.TakeDamage(10);
            Destroy(collision.gameObject);
        }
    }

    private void HandlePlayerDeath()
    {
        Debug.Log("Player Defeated!");
        gameManager?.GameOver();
    }
}