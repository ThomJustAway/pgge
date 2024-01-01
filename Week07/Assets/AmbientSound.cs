using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioSource mAudioSource;
 
    public void Play(AudioClip clip, float volume = 1.0f, float pitch = 1.0f, bool loop = true)
    {
        if (mAudioSource.isPlaying)
            mAudioSource.Stop();
        mAudioSource.clip = clip;
        mAudioSource.pitch = pitch;
        mAudioSource.volume = volume;
        mAudioSource.loop = loop;
        mAudioSource.Play();
    }

}
