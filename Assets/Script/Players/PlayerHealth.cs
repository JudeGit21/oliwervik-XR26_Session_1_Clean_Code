using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private float health = 30f;
    public float MaxHealth => 30f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        health = Mathf.Clamp(health, 0, MaxHealth);
        GetComponent<PlayerUI>()?.UpdateHealthUI(health, MaxHealth);

        if (health <= 0)
        {
            FindObjectOfType<GameManager>()?.GameOver();
        }
    }
}