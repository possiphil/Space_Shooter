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
    private AudioSource ability1AudioSource;
    private AudioSource ability2AudioSource;
    private AudioSource ability3AudioSource;
    private AudioSource hitMarkerAudioSource;
    private AudioSource killConfirmedAudioSource;

    private int randomIndex;
    [SerializeField] public AudioClip[] FiringSounds;
    [SerializeField] public AudioClip ability1;
    [SerializeField] public AudioClip ability2;
    [SerializeField] public AudioClip ability3;
    [SerializeField] public AudioClip hitMarker;
    [SerializeField] public AudioClip killConfirmed;




void Start()
{
    soundManager = this;
    explosionAudioSource = gameObject.AddComponent<AudioSource>();
    firingAudioSource = gameObject.AddComponent<AudioSource>();
    enemy1AudioSource = gameObject.AddComponent<AudioSource>();
    enemy2AudioSource = gameObject.AddComponent<AudioSource>();
    ability1AudioSource = gameObject.AddComponent<AudioSource>();
    ability2AudioSource = gameObject.AddComponent<AudioSource>();
    ability3AudioSource = gameObject.AddComponent<AudioSource>();
    hitMarkerAudioSource = gameObject.AddComponent<AudioSource>();
    killConfirmedAudioSource = gameObject.AddComponent<AudioSource>();
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
public void PlayAbility1Sound()
{

    ability1AudioSource.volume = Random.Range(0.25f, 0.3f); //change Volume range of Firing Sound
    ability1AudioSource.pitch = Random.Range(0.8f, 1.2f); //change pitch range of Firing Sound
    ability1AudioSource.PlayOneShot(ability1);
}
public void PlayAbility2Sound()
{

    ability2AudioSource.volume = Random.Range(0.25f, 0.3f); //change Volume range of Firing Sound
    ability2AudioSource.pitch = Random.Range(1f, 1f); //change pitch range of Firing Sound
    ability2AudioSource.PlayOneShot(ability2);
}
public void PlayAbility3Sound()
{

    ability3AudioSource.volume = Random.Range(0.25f, 0.3f); //change Volume range of Firing Sound
    ability3AudioSource.pitch = Random.Range(1f, 1f); //change pitch range of Firing Sound
    ability3AudioSource.PlayOneShot(ability3);
}
public void PlayHitMarkerSound()
{

    hitMarkerAudioSource.volume = Random.Range(0.25f, 0.3f); //change Volume range of Firing Sound
    hitMarkerAudioSource.pitch = Random.Range(0.8f, 1.2f); //change pitch range of Firing Sound
    hitMarkerAudioSource.PlayOneShot(hitMarker);
}
public void PlayKillConfirmedSound()
{

    killConfirmedAudioSource.volume = Random.Range(0.4f, 0.5f); //change Volume range of Firing Sound
    killConfirmedAudioSource.pitch = Random.Range(0.9f, 1.1f); //change pitch range of Firing Sound
    killConfirmedAudioSource.PlayOneShot(killConfirmed);
}

}
