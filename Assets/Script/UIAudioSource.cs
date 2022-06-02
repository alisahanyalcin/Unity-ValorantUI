using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UIAudioSource : MonoBehaviour
{
    public static UIAudioSource Singleton;

    [SerializeField] private AudioSource audioSource;
    [SerializeField][Range(0f, 1f)] private float volume = 1f;

    private void Awake()
    {
        if (Singleton == null)
            Singleton = this;
        else
            Destroy(this);

        // if audio source is null then set it to the audio source on this game object.
        if (audioSource == null)
            audioSource = this.gameObject.GetComponent<AudioSource>();

        audioSource.playOnAwake = false;
    }

    public void PlayAudio(AudioClip clip)
    {
        audioSource.PlayOneShot(clip, volume);
    }

    public void PlayAudio(AudioClip clip, float _volume)
    {
        audioSource.PlayOneShot(clip, this.volume * _volume);
    }
}