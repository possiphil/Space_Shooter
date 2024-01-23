using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Enemy2Movement : MonoBehaviour
{
    [SerializeField] private float enemy2speed = 10f;
    [SerializeField] public float distanceToExplode = 1f;

    [SerializeField] public GameObject explosionEnemy2;

    private Rigidbody rb;
    public Transform player;
    private Vector3 movement;
    

    [SerializeField] private int Health = 5;
    private int currentHealth;
    

    private void Start()
    {
        currentHealth = Health;
        
        rb = this.GetComponent<Rigidbody>();
      

        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        
        direction.Normalize();
        movement = direction;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

       
        rb.MoveRotation(rotation);
        PlayerToFarAway();


    }

    private void FixedUpdate()
    {
        if ((player.position - transform.position).magnitude <= distanceToExplode)
        {
            var transform1 = transform;
            Instantiate(explosionEnemy2, transform1.position, transform1.rotation);
            Destroy(gameObject);
        }
        else
        {
            moveEnemy(movement);
        }
    }

    private void moveEnemy(Vector3 direction)
    {
        rb.MovePosition(transform.position + (enemy2speed * Time.deltaTime * direction));
    }

    private void PlayerToFarAway()
    {
        float DistanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (DistanceToPlayer> 15f)
        {
            enemy2speed = 100;
        }
        else
        {
            enemy2speed = 3;
        }
      
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
        Instantiate(explosionEnemy2, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

