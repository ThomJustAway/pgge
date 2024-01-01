using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSound : MonoBehaviour
{
    public AudioClip[] mAudioClips;
    public float mMinSoundDuration = 10.0f;
    public float mMaxSoundDuration = 20.0f;
    private float mCurrentSoundDuration = 1.0f;
    private AmbientSound mAmbientSound;

    void Start()
    {
        mAmbientSound = GameApp.Instance.mAmbientSound;
        StartCoroutine(WaitForDuration());
    }

    void PlayAmbientSound()
    {
        if (mAudioClips.Length > 0)
        {
            StartCoroutine(StartFade(mAmbientSound.mAudioSource, 0.3f, 1));
            int index = Random.Range(0, mAudioClips.Length - 1);
            mCurrentSoundDuration = Random.Range(mMinSoundDuration, mMaxSoundDuration);
            mAmbientSound.Play(mAudioClips[index]);
            Debug.Log("Playing sound " + index.ToString() + " for " + mCurrentSoundDuration + " secs");
        }
    }

    public IEnumerator WaitForDuration()
    {
        while (true)
        {
            yield return new WaitForSeconds(mCurrentSoundDuration);
            yield return StartFade(mAmbientSound.mAudioSource, 0.3f, 0);
            PlayAmbientSound();
        }
    }

    public IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

}
