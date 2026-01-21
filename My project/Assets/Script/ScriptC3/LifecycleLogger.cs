using UnityEngine;

public class LifecycleLogger : MonoBehaviour
{
    void Awake()
    {
        Debug.Log($"{name} - Awake");
    }

    void OnEnable()
    {
        Debug.Log($"{name} - OnEnable");
    }

    void Start()
    {
        Debug.Log($"{name} - Start");
    }

    void Update()
    {
        Debug.Log($"{name} - Update");
    }

    void FixedUpdate()
    {
        Debug.Log($"{name} - FixedUpdate");
    }

    void LateUpdate()
    {
        Debug.Log($"{name} - LateUpdate");
    }

    void OnDisable()
    {
        Debug.Log($"{name} - OnDisable");
    }

    void OnDestroy()
    {
        Debug.Log($"{name} - OnDestroy");
    }
}
