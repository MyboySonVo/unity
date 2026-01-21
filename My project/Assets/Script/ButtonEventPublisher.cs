using UnityEngine;
using UnityEngine.Events;

public class ButtonEventPublisher : MonoBehaviour
{
    public UnityEvent onButtonPressed;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space pressed! Triggering event.");
            onButtonPressed?.Invoke();
        }
    }
}
