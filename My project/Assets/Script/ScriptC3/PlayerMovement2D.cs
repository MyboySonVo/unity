using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 moveDir;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(h, v);

        if (moveDir.magnitude > 1)
            moveDir.Normalize();

        transform.position += (Vector3)(moveDir * speed * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position,
                        transform.position + (Vector3)moveDir * 1.5f);
    }
}
