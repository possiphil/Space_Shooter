using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy1Laser : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameObject target;

    [SerializeField] private float destroyAfterSeconds;

//    private bool isDestroyed = false;


    private void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        ShootLaser();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("hitPlayer");
            Destroy(gameObject);
        }
    }
    private void ShootLaser()
    {


        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");

        if (target != null)
        {
            Vector3 moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
            rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
        }
        else
        {
            Debug.LogWarning("No Player");
        }

        DestroyAfterDelay();
    }
    
    private void DestroyAfterDelay()
    {
        Invoke("DestroyBullet", destroyAfterSeconds);
    }

    private void DestroyBullet()
    {
        //if (!isDestroyed)
        //{
          //  isDestroyed = true;
            
            Destroy(gameObject);
        //}
      
    }
    
}
