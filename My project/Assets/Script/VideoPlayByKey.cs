using UnityEngine;
using UnityEngine.Video;

public class VideoPlayByKey : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
            Debug.Log("Play video");
        }
    }
}
