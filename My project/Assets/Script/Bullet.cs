using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 10;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Cấu hình Rigidbody2D
        rb.linearVelocity = transform.up * flySpeed;
        rb.gravityScale = 0f;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        
        // Bật continuous collision detection
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        
        Destroy(gameObject, 3f); // tự hủy sau 3 giây
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Phát hiện va chạm với kẻ địch
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
