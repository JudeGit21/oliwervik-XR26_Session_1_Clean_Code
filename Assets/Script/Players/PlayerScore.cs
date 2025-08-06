using UnityEngine;

public class PlayerScore : MonoBehaviour, IScorable
{
    public int Score { get; private set; }

    public void AddScore(int amount)
    {
        Score += amount;
        GetComponent<PlayerUI>()?.UpdateScoreUI(Score);

        if (Score >= 30)
        {
            FindObjectOfType<GameManager>()?.WinGame();
        }
    }
}