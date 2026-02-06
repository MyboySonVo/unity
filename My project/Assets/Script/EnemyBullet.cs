using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float flySpeed = 8f;    // tốc độ đạn
    public int damage = 10;        // sát thương
    public float lifeTime = 3f;    // thời gian tồn tại

    private Vector3 direction = Vector3.down; // luôn bay xuống

    private void Start()
    {
        // Tự hủy sau lifeTime giây
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.position += direction * flySpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"EnemyBullet.OnTriggerEnter2D: hit {collision.gameObject.name}, tag={collision.tag}");
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log("EnemyBullet: hit Player tag - attempting TakeDamage");
            var player = collision.GetComponent<PlayerHealth>();
            if (player != null)
            {
                Debug.Log($"EnemyBullet: found PlayerHealth, dealing {damage} damage");
                player.TakeDamage(damage);
            }
            else
            {
                Debug.LogWarning($"EnemyBullet: collision object has Player tag but no PlayerHealth component");
            }
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Obstacle"))
        {
            Debug.Log("EnemyBullet: hit Obstacle");
            Destroy(gameObject);
        }
    }
}
