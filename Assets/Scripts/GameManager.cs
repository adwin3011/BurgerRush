using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI finalScoreText;
    public GameObject gameOverPanel;

    private int score = 0;
    private float timeLeft = 60f;
    private bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);

            if (Mathf.CeilToInt(timeLeft) <= 0)
            {
                gameOver = true;
                timerText.text = "Time: 0";
                gameOverPanel.SetActive(true);
                finalScoreText.text = "Final Score: " + score;
            }
        }
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}