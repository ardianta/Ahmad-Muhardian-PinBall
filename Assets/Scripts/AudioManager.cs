using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // kita masukan audio source BGM di sini
    public AudioSource bgmAudioSource;
    public GameObject sfxBumperAudioSource;
    public GameObject sfxSwitchOnAudioSource;
    public GameObject sfxSwitchOffAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }


    // fungsi buat play BGM
    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    // fungsi buat play SFX
    // ini tidak di jalankan pada script ini, tapi nanti di jalankan pada script bumpernya
    public void PlayBumperSFX(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
    	// memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(sfxBumperAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchOnSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchOnAudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchOffSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxSwitchOffAudioSource, spawnPosition, Quaternion.identity);
    }
}
