using UnityEngine;

public class GlobalAudioController : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
            Debug.Log(isMuted ? "Audio Muted" : "Audio Unmuted");
        }

        
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                AudioListener.pause = true;
                Debug.Log("Audio Paused");
            }
            else
            {
                AudioListener.pause = false;
                Debug.Log("Audio Resumed");
            }
        }
    }
}