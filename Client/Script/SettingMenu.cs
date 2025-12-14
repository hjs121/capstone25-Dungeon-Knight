using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;


    // 소리 조절
    public void SetVolume(float sliderValue)
    {
        float soundLevel = Mathf.Log10(sliderValue) * 20;

        audioMixer.SetFloat("Master", soundLevel);
    }

    // 전체화면 설정
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}