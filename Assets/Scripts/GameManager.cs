using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    
    private int score = 0;
    private float timeLeft = 60f;
    private bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                gameOver = true;
                timerText.text = "Time: 0";
            }
        }
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}