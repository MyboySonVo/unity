using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public event Action<int> OnHealthChanged;
    public GameObject gameOverUI; // Assign the Game Over UI in the Inspector

    private void Start()
    {
        OnHealthChanged?.Invoke(health); // cập nhật ban đầu
    }

    private void Update()
    {
        // Test giảm máu bằng H
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }

    // Thêm hàm public để EnemyBullet gọi
    public void TakeDamage(int damage)
    {
        health -= damage;
        OnHealthChanged?.Invoke(health);
        Debug.Log("Player bị trừ " + damage + " máu, còn " + health);

        if (health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        Debug.Log("GAME OVER");

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Game Over UI is not assigned in the Inspector.");
        }
    }
}
