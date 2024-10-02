using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public void HomeButton()
    {
        AudioPlayer.instance.ButtonSound();
        GameManager.instance.ReloadHome();
    }
    public void ReloadButton()
    {
        AudioPlayer.instance.ButtonSound();
        GameManager.instance.ReloadGame();
    }
}
