using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] public AudioClip[] explosionSounds;
    [SerializeField] public AudioClip[] enemy1FiringSounds;
    [SerializeField] public AudioClip[] enemy2FiringSounds;
    public static SoundManager soundManager;
    private AudioSource explosionAudioSource;
    private AudioSource firingAudioSource;
    private AudioSource enemy1AudioSource;
    private AudioSource enemy2AudioSource;
    private int randomIndex;
    [SerializeField] public AudioClip[] FiringSounds;



void Start()
{
    soundManager = this;
    explosionAudioSource = gameObject.AddComponent<AudioSource>();
    firingAudioSource = gameObject.AddComponent<AudioSource>();
    enemy1AudioSource = gameObject.AddComponent<AudioSource>();
    enemy2AudioSource = gameObject.AddComponent<AudioSource>();
}

public void PlayExplosionSound()
{
    randomIndex = Random.Range(0, explosionSounds.Length);

    explosionAudioSource.volume = Random.Range(0.2f, 0.3f); //change Volume range of Explosion Sound
    explosionAudioSource.pitch = Random.Range(0.8f, 1.2f); //change pitch range of Explosion Sound
    explosionAudioSource.PlayOneShot(explosionSounds[randomIndex]);
}

public void PlayFiringSound()
{
    randomIndex = Random.Range(0, FiringSounds.Length);

    firingAudioSource.volume = Random.Range(0.45f, 0.5f); //change Volume range of Firing Sound
    firingAudioSource.pitch = Random.Range(0.8f, 1.2f); //change pitch range of Firing Sound
    firingAudioSource.PlayOneShot(FiringSounds[randomIndex]);
}
public void PlayEnemy1FiringSound()
{
    randomIndex = Random.Range(0, enemy1FiringSounds.Length);

    enemy1AudioSource.volume = Random.Range(0.45f, 0.5f); //change Volume range of Firing Sound
    enemy1AudioSource.pitch = Random.Range(0.8f, 1.2f); //change pitch range of Firing Sound
    enemy1AudioSource.PlayOneShot(enemy1FiringSounds[randomIndex]);
}
public void PlayEnemy2FiringSound()
{
    randomIndex = Random.Range(0, enemy2FiringSounds.Length);

    enemy2AudioSource.volume = Random.Range(0.25f, 0.3f); //change Volume range of Firing Sound
    enemy2AudioSource.pitch = Random.Range(0.8f, 1.2f); //change pitch range of Firing Sound
    enemy2AudioSource.PlayOneShot(enemy2FiringSounds[randomIndex]);
}

}
