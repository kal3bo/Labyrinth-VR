using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;

    private void Start()
    {
        scoreText = gameObject.GetComponent<Text>();
    }
    public void UpdateScore(int score)
    {
        scoreText.text = "Best: " + score;
    }
}
