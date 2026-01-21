using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthUnityEvent : MonoBehaviour
{
    public int health = 100;
    public UnityEvent<int> OnHealthChanged;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
            OnHealthChanged.Invoke(health);
        }
    }
}
