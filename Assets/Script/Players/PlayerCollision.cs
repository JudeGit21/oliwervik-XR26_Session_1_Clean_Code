using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Collectible"))
        {
            GetComponent<PlayerScore>()?.AddScore(10);
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("Enemy"))
        {
            GetComponent<PlayerHealth>()?.TakeDamage(10);
            Destroy(col.gameObject);
        }
    }
}