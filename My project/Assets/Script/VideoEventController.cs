using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; // Nếu muốn chuyển scene

public class VideoEventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI; // UI hiện khi video kết thúc
    public string nextSceneName; // tên scene gameplay nếu muốn load

    void Start()
    {
        // Ẩn UI khi bắt đầu
        endUI.SetActive(false);

        // Đăng ký event
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;

        // Chuẩn bị video
        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared");
        vp.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video finished");
        EndVideo();
    }

    // Hàm gọi khi video kết thúc hoặc skip
    void EndVideo()
    {
        endUI.SetActive(true);

        // Nếu muốn chuyển scene:
        if (!string.IsNullOrEmpty(nextSceneName))
            SceneManager.LoadScene(nextSceneName);
    }

    // Gọi từ button Skip
    public void SkipVideo()
    {
        Debug.Log("Video skipped");
        videoPlayer.Stop();
        EndVideo();
    }


    public void LoadGameplay()
    {
        SceneManager.LoadScene("Battle");
        Debug.Log("CLICK");

    }
}
