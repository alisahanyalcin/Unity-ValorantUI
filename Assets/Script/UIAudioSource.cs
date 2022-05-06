using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudioSource : MonoBehaviour
{
    // Singleton
    public static UIAudioSource Singleton;

    // Volume of the audio source (0-1)
    [SerializeField][Range(0f, 1f)] private float _volume = 1f;

    // AudioSource component attached to this game object (can be null)
    [SerializeField] private AudioSource _audioSource;

    private void Awake()
    {
        if (Singleton == null)
            Singleton = this;
        else
            Destroy(this);

        // if audio source is null then set it to the audio source on this game object.
        if (_audioSource == null)
            _audioSource = this.gameObject.GetComponent<AudioSource>();

        _audioSource.playOnAwake = false;
    }

    public void PlayAudio(AudioClip clip)
    {
        _audioSource.PlayOneShot(clip, _volume);
    }

    public void PlayAudio(AudioClip clip, float volume)
    {
        _audioSource.PlayOneShot(clip, _volume * volume);
    }
}