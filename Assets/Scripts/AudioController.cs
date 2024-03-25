using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;

    AudioSource _myAudio;
    private void Awake()
    {
        instance = this;
        _myAudio = GetComponent<AudioSource>();
    }
    public void PlayThisAudio(string clipName, float volum)
    {
        _myAudio.volume = volum;
        _myAudio.PlayOneShot((AudioClip)Resources.Load("Audio/" + clipName, typeof(AudioClip)));
    }
}