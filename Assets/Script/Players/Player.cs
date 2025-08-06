using UnityEngine;

public class Player : MonoBehaviour
{
    private void Awake()
    {
        // Add required components if needed
        if (GetComponent<PlayerMovement>() == null)
            gameObject.AddComponent<PlayerMovement>();

        if (GetComponent<PlayerJump>() == null)
            gameObject.AddComponent<PlayerJump>();

        if (GetComponent<PlayerHealth>() == null)
            gameObject.AddComponent<PlayerHealth>();

        if (GetComponent<PlayerScore>() == null)
            gameObject.AddComponent<PlayerScore>();

        if (GetComponent<PlayerRotation>() == null)
            gameObject.AddComponent<PlayerRotation>();

        if (GetComponent<PlayerCollision>() == null)
            gameObject.AddComponent<PlayerCollision>();

        if (GetComponent<PlayerUI>() == null)
            gameObject.AddComponent<PlayerUI>();
    }
}