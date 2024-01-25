using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy3 : MonoBehaviour
{
   //Movement
   private Vector3 movement;
   private float moveSpeed = 1f;
   private Vector3 targetPoint;
   //Components
   private Transform player;
   private Rigidbody rb;
   [SerializeField] private GameObject explosionEnemy3;
   //Shooting
   [SerializeField] private GameObject bigProjectilePrefab;
   [SerializeField] private GameObject smallProjectilePrefab;
   [SerializeField] private float interval;
   [SerializeField] private float timer;
   [SerializeField] private GameObject enemy;
   [SerializeField] private Transform[] cannons;
   //Health
   private int Health = 8;
   private int currentHealth;

 
  

   private void Start()
   {
      currentHealth = Health;
      GetNeededComponents();
      GetRandomPoints();
   }

   private void Update()
   {
      LookToPlayer();
      MoveToRandomPoint();
      timer += Time.deltaTime;
      if (timer >= interval)
      {
         Shoot();
         timer = 0f;
      }
      EnemyTooFarAway();
   }
   private void GetNeededComponents()
   {
      rb = GetComponent<Rigidbody>();
      GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
      player = playerObject.transform;
      
      Renderer[] childRenderers = GetComponentsInChildren<Renderer>(true);
      if (childRenderers.Length > 0)
      {
         //EnemyRenderer = childRenderers[0];
      }
      else
      {
         Debug.Log("No renderer found on child object");
      }

      cannons = new Transform[4];
      cannons[0] = transform.Find("Cannon1");
      cannons[1] = transform.Find("Cannon2");
      cannons[2] = transform.Find("Cannon3");
      cannons[3] = transform.Find("Cannon4");
      
   }

   private void GetRandomPoints()
   {
      float cameraHeight = Camera.main.orthographicSize;
      float cameraWidth = Camera.main.aspect * cameraHeight;

      float randomX = Random.Range(-cameraWidth, cameraWidth);
      float randomY = Random.Range(-cameraHeight, cameraHeight);

      targetPoint = player.position + new Vector3(randomX, randomY, 0f);
   }

   private void MoveToRandomPoint()
   {
      float step = moveSpeed * Time.deltaTime;
      transform.position = Vector3.Lerp(transform.position, targetPoint, step);
      
      if (Vector3.Distance(transform.position, targetPoint) < 0.1f)
      {
         GetRandomPoints();
      }
   }

   
   private void LookToPlayer()
   {
      Vector3 direction = player.position - transform.position;

      direction.Normalize();
      movement = direction;

      float angle1 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
      Quaternion rotation = Quaternion.AngleAxis(angle1, Vector3.forward);


      rb.rotation = rotation;
   }

   private void Shoot()
   {
      Instantiate(bigProjectilePrefab, cannons[0].position, cannons[1].rotation);
      Instantiate(bigProjectilePrefab, cannons[3].position, cannons[3].rotation);
      
      Instantiate(smallProjectilePrefab, cannons[1].position, cannons[1].rotation);
      Instantiate(smallProjectilePrefab, cannons[2].position, cannons[2].rotation);
      SoundManager.soundManager.PlayEnemy2FiringSound();
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
      currentHealth -= damage;
      if (currentHealth <= 0)
      {
         DestroyEnemy();
      }
   }
   private void DestroyEnemy()
   {
      Instantiate(explosionEnemy3, transform.position, Quaternion.identity);
      Destroy(gameObject);
      SoundManager.soundManager.PlayExplosionSound();
   }
   private void EnemyTooFarAway()
   {
      float DistanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
      if (DistanceToPlayer > 1000f)
      {
         Destroy(gameObject);
      }
   }
}
