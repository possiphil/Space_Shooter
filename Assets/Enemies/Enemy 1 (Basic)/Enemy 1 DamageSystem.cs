using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1DamageSystem : MonoBehaviour
{
  [SerializeField] private int maxHealth = 5;
  [SerializeField] private int currentHealth;
  [SerializeField] private GameObject explosion;
  private void Start()
  {
    currentHealth = maxHealth;
    
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("PlayerProjectile"))
    {
      TakeDamage(1);
    }
  }

  private void TakeDamage(int damage)
  {
    SoundManager.soundManager.PlayHitMarkerSound();
    currentHealth -= damage;
    if (currentHealth <= 0)
    {
      DestroyEnemy();
      Instantiate(explosion, transform.position, Quaternion.identity);
    }
  }

 

  private void DestroyEnemy()
  {
   
    Destroy(gameObject);
    SoundManager.soundManager.PlayExplosionSound();
    SoundManager.soundManager.PlayKillConfirmedSound();
  }
}

