using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI title, score, highscore;
    public Button play, music, sound;
    public bool Music, Audio;

    public SoundManager soundManager;

    public void ChangeMenu(bool x)
    {
        score.gameObject.SetActive(!x);
        highscore.gameObject.SetActive(!x);

        title.gameObject.SetActive(x);
        play.gameObject.SetActive(x);
        music.gameObject.SetActive(x);
        sound.gameObject.SetActive(x);
    }

    public void ChangeAudio()
    {
        Audio = !Audio;
        soundManager.AsDie.mute = Audio;
        soundManager.AsJump.mute = Audio;
    }

    public void ChangeMusic()
    {
        Music = !Music;
        soundManager.AsMusic.mute = Music;
    }
}
