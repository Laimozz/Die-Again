using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{

    [SerializeField] AudioSource audioSource;
    public static AudioPlayer instance;
    [SerializeField] AudioClip walkSound;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip buttonSound;
    [SerializeField] AudioClip dieSound;
    [SerializeField] float volum = 0.8f;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        ManageSingleton();
    }
    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void AudioButton(Button audioButton , Button muteAudioButton)
    {
        if (audioButton != null)
        {
            audioSource.mute = true;
            audioButton.gameObject.SetActive(false);
            muteAudioButton.gameObject.SetActive(true);
            ButtonSound();

        }
    }
    public void MuteAudioButton(Button audioButton , Button muteAudioButton)
    {
        if (muteAudioButton != null)
        {
            audioSource.mute = false;
            muteAudioButton.gameObject.SetActive(false);
            audioButton.gameObject.SetActive(true);
            ButtonSound();
        }
    }
    public void RunSound()
    {
        Vector3 pos = Camera.main.transform.position;
        PlayShootClip(walkSound, pos , volum);
    }
    public void JumpSound()
    {
        Vector3 pos = Camera.main.transform.position;
        PlayShootClip(jumpSound, pos , volum);
    }
    public void ButtonSound()
    {
        Vector3 pos = Camera.main.transform.position;
        PlayShootClip(buttonSound, pos, volum);
    }
    public void DieSound()
    {
        Vector3 pos = Camera.main.transform.position;
        PlayShootClip(dieSound, pos, volum);
    }
    public void PlayShootClip(AudioClip clip, Vector3 pos, float volume)
    {

        AudioSource.PlayClipAtPoint(clip, pos, volume);
    }
}
