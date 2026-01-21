using UnityEngine;
using TMPro;

public class UIHealth : MonoBehaviour
{
    public PlayerHealth player;
    public TextMeshProUGUI hpText;

    void OnEnable()
    {
        if (player != null)
        {
            player.OnHealthChanged += UpdateHP;

            // ⭐ QUAN TRỌNG: sync UI lần đầu
            UpdateHP(player.health);
        }
    }

    void OnDisable()
    {
        if (player != null)
            player.OnHealthChanged -= UpdateHP;
    }

    void UpdateHP(int hp)
    {
        hpText.text = $"HP: {hp}";
    }
}
