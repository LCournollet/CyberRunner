using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    PlayerController _playerController;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore()
    {
        _playerController = FindObjectOfType<PlayerController>();
        Debug.Log("Updated score text");
        scoreText.text = $"Player Level: {_playerController.playerLevel}";
    }
}
