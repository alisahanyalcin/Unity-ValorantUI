using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace alisahanyalcin
{
    public class UIPlayAudio : MonoBehaviour
    {
        [SerializeField] private AudioClip audioClip;
        [SerializeField] [Range(0f, 1f)] private float volume = 1f;
        
        public void PlayAudio()
        {
            if (!this.enabled || !this.gameObject.activeInHierarchy)
                return;

            if (this.audioClip == null)
                return;

            if (UIAudioSource.Singleton == null)
            {
                Debug.LogWarning("You dont have UIAudioSource in your scene. Cannot play audio clip.");
                return;
            }

            // Play the audio clip
            UIAudioSource.Singleton.PlayAudio(this.audioClip, this.volume);
        }
    }
}
