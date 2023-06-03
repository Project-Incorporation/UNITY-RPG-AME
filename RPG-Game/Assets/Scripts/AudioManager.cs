using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] sfx;
    public AudioSource[] bgm;

    public float sfxVolume = 0.2f; // Default SFX volume
    public float bgmVolume = 0.2f; // Default BGM volume

    public static AudioManager instance;

    void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        PlayRandomMusic();
    }

    public void PlaySFX(int soundToPlay)
    {
        if (soundToPlay < sfx.Length)
        {
            sfx[soundToPlay].volume = sfxVolume; // Set the volume for the SFX
            sfx[soundToPlay].Play();
        }
    }

    public void PlayBGM(int musicToPlay)
    {
        if (!bgm[musicToPlay].isPlaying)
        {
            StopMusic();

            if (musicToPlay < bgm.Length)
            {
                bgm[musicToPlay].volume = bgmVolume; // Set the volume for the BGM
                bgm[musicToPlay].Play();
            }
        }
    }

    public void StopMusic()
    {
        for (int i = 0; i < bgm.Length; i++)
        {
            bgm[i].Stop();
        }
    }

    public void SetVolume(float volume)
    {
        sfxVolume = volume;
        bgmVolume = volume;

        // Update the volume for all existing audio sources
        for (int i = 0; i < sfx.Length; i++)
        {
            sfx[i].volume = sfxVolume;
        }

        for (int i = 0; i < bgm.Length; i++)
        {
            bgm[i].volume = bgmVolume;
        }
    }

    public void PlayRandomMusic()
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(1, bgm.Length);

        if (Input.GetKeyDown(KeyCode.T))
        {
            PlayBGM(randomNumber);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StopMusic();
        }
    }
}
