using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public float MaxHealth = 30f;
    public float CurrentHealth { get; private set; }

    public delegate void HealthChanged(float value);
    public event HealthChanged OnHealthChanged;

    public delegate void PlayerDied();
    public event PlayerDied OnPlayerDied;

    private void Start()
    {
        CurrentHealth = MaxHealth;
        OnHealthChanged?.Invoke(CurrentHealth);
    }

    public void TakeDamage(float amount)
    {
        CurrentHealth -= amount;
        CurrentHealth = Mathf.Max(CurrentHealth, 0);
        OnHealthChanged?.Invoke(CurrentHealth);

        if (CurrentHealth <= 0)
        {
            OnPlayerDied?.Invoke();
        }
    }
}
