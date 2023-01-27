using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public TMP_Text LevelText;
    public int EnemyLevel = 1;
    public static int GlobalLevel;
    private PlayerController _playerController;
    

    private GameManager _gameManager;
    private void Awake()
    {
        _playerController = FindObjectOfType<PlayerController>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        EnemyLevel = Random.Range(_playerController.playerLevel * _gameManager.EnemiesCount, GlobalLevel);
        GlobalLevel += EnemyLevel;

        _gameManager.EnemiesCount++;
        LevelText.text = EnemyLevel.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enemy gets triggered");
        Destroy(collision.gameObject);
        if (_playerController.playerLevel >= EnemyLevel)
        {
            Destroy(gameObject);
            _playerController.playerLevel += EnemyLevel;
            _gameManager.EnemiesCount--;
        }
    }
}