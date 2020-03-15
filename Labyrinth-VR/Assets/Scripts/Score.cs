using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text _ScoreText;
    private int _CurrenScore = 0;

    private void Start()
    {
        _ScoreText = gameObject.GetComponent<Text>();
    }

    /// <summary>
    /// If the player sink the ball in one hole, the score
    /// will update onl if the number of the hole is bigger
    /// than the previous one.
    /// </summary>
    public void UpdateScore(int score)
    {
        if (score > _CurrenScore)
        {
            _ScoreText.text = "Best: " + score;
            _CurrenScore = score;
        }
    }
}
