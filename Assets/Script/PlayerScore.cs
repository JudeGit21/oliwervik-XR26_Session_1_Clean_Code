using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int Score { get; private set; }

    public delegate void ScoreChanged(int newScore);
    public event ScoreChanged OnScoreChanged;

    public void AddScore(int value)
    {
        Score += value;
        OnScoreChanged?.Invoke(Score);
    }
}