using UnityEngine;
using TMPro;

public class SignedAngle2D : MonoBehaviour
{
    public TextMeshProUGUI angleText;

    void Update()
    {
        Vector3 mouseWorld =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0;

        Vector2 dir = mouseWorld - transform.position;
        float angle = Vector2.SignedAngle(Vector2.up, dir);

        transform.rotation = Quaternion.Euler(0, 0, angle);

        angleText.text = $"Angle: {angle:F1}";
    }
}
