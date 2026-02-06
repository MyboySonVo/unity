using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // Gán prefab đạn trong Inspector
    public Transform shootPoint;    // Vị trí bắn, optional
    public float shootInterval = 1f;

    private void Awake()
    {
        // Tự tạo shootPoint nếu chưa gán
        if (shootPoint == null)
        {
            GameObject sp = new GameObject("ShootPoint");
            sp.transform.SetParent(transform);
            sp.transform.localPosition = Vector3.zero;
            shootPoint = sp.transform;
        }
    }

    private void Start()
    {
        if (bulletPrefab == null)
        {
            Debug.LogError("EnemyShooter: bulletPrefab chưa gán!");
            return;
        }

        // Lặp bắn liên tục
        InvokeRepeating(nameof(ShootDown), 0.5f, shootInterval);
    }

    private void ShootDown()
    {
        Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
    }
}
