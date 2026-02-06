using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int maxHealth = 100; // thêm health
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    // Hàm TakeDamage mà Bullet gọi
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position,
                transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }
}
