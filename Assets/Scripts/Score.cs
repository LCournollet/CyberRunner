using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(int enemiesCount)
    {
        Debug.Log("Updated score text");

        scoreText.text = $"Level: {enemiesCount}";
    }
}
