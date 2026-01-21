using UnityEngine;

public class TurretRotation2D : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 180f;
    public bool smooth = true;

    void Update()
    {
        Vector2 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;

        Quaternion targetRot = Quaternion.Euler(0, 0, angle);

        if (smooth)
        {
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRot,
                rotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = targetRot;
        }
    }
}
