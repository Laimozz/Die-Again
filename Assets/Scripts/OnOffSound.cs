using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffSound : MonoBehaviour
{
    [SerializeField] Button audioButton;
    [SerializeField] Button muteAudioButton;
    public void Off()
    {
        Debug.Log("Off");
        AudioPlayer.instance.AudioButton(audioButton , muteAudioButton);
    }
    public void On()
    {
        Debug.Log("On");
        AudioPlayer.instance.MuteAudioButton(audioButton , muteAudioButton);
    }
}
