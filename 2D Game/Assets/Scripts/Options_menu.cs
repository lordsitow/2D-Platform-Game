using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options_menu : MonoBehaviour
{
    public AudioMixer audio_mixer;

    public void Set_volume(float volume)
    {
        audio_mixer.SetFloat("volume", volume);
    }
}
