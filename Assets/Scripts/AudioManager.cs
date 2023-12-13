using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // kita masukan audio source BGM di sini
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // fungsi buat play BGM
    public void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    // fungsi buat play SFX
    // ini tidak di jalankan pada script ini, tapi nanti di jalankan pada script bumpernya
    public void PlaySFX(Vector3 spawnPosition)
    {
        // berbeda dengan bgm, disini kita buat script untuk 
    	// memunculkan prefabnya pada posisi sesuai dengan parameternya
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
