using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource AsMusic, AsJump, AsDie;
    void Start()
    {
        Play();
    }

    public void Play()
    {
        AsMusic.Play();
    }
    public void PlayJump()
    {
        AsJump.Play();
    }
    public void PlayDie()
    {
        AsDie.Play();
    }

}
