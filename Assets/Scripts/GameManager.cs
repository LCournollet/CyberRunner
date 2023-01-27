using Newtonsoft.Json.Linq;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private Score scoreComponent;

    private int _enemiesCount;
    public int EnemiesCount
    {
        get
        {
            return _enemiesCount;
        }
        set
        {
            _enemiesCount = value;
            CheckEnemiesCountLeft();
            scoreComponent.UpdateScore();
        }
    }

    private void Awake()
    {
        scoreComponent = FindObjectOfType<Score>();
    }

    private void CheckEnemiesCountLeft()
    {
        if (_enemiesCount <= 0)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        Debug.Log("LoadNextScene");
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
    }
}
