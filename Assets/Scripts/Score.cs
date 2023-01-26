using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        // A : Code qui permet de s'initialiser soi-même
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    //private void Start()
    //{
    // B : Code qui permet d'initialiser les autres, ou autre...
    //}

    //private void Update()
    //{

    //}

    public void UpdateScore(int enemiesCount)
    {
        Debug.Log("Updated score text");

        scoreText.text = $"Enemies: {enemiesCount}";
    }
}
