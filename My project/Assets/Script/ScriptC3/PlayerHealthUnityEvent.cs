using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class HealthChangedEvent : UnityEvent<int> { }

public class PlayerHealthUnityEvent : MonoBehaviour
{
    public int health = 100;

    // Sử dụng [SerializeField] + custom UnityEvent class để hiển thị trong Inspector
    public HealthChangedEvent OnHealthChanged;

    private void Awake()
    {
        if (OnHealthChanged == null)
            OnHealthChanged = new HealthChangedEvent(); // khởi tạo mặc định
    }

    void Update()
    {
        // Test giảm máu bằng phím H
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
            health = Mathf.Max(health, 0);

            Debug.Log($"Health: {health}");
            OnHealthChanged.Invoke(health); // thông báo cho UI
        }
    }
}
