using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public event Action<int> OnHealthChanged;
    public GameObject gameOverUI; // Assign the Game Over UI in the Inspector

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
            OnHealthChanged?.Invoke(health);

            if (health <= 0)
            {
                Debug.Log("GAME OVER");
                GameOver();
            }
        }
    }

    void GameOver()
    {
        // Stop the game
        Time.timeScale = 0;
        Debug.Log("Game has been stopped.");

        // Show Game Over UI
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