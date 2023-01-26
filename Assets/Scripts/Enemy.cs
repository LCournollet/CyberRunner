using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        _gameManager.EnemiesCount++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enemy gets triggered");

        Destroy(gameObject);
        Destroy(collision.gameObject);

        _gameManager.EnemiesCount--;
    }
}