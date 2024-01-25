using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Enemy1Movement : MonoBehaviour
{
   public Transform Player;
   private Rigidbody rb;
   private Vector3 movement;

   [SerializeField] private float moveSpeed = 2f;
   [SerializeField] private float StopDistance = 3f;
   [SerializeField] private float farAwayDistance = 30f;
   [SerializeField] private float farAwaySpeed = 100f;
   
  

   private void Start()
   {
       GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
       Player = playerObject.transform;
       rb = GetComponent<Rigidbody>();
       
   }

   private void Update()
   {
     
       
       Vector3 direction = Player.position - transform.position;
       
       direction.Normalize();
       movement = direction;

       float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

       
       rb.MoveRotation(rotation);
       PlayerToFarAway();
       EnemyTooFarAway();
      
   }

   private void FixedUpdate()
   {
       float distanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);

       if (distanceToPlayer <= StopDistance)
       {
           moveSpeed = 0;
       }
       else
       {
           if (distanceToPlayer > farAwayDistance)
           {
               moveSpeed = farAwaySpeed;
           }
           else
           {
               moveSpeed = 2;
           }

           moveEnemy(movement);
       }
   }

   private void moveEnemy(Vector3 direction)
   {

       rb.MovePosition(transform.position + (moveSpeed * Time.deltaTime * direction));
       
   }

   private void PlayerToFarAway()
   {
       float DistanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);
       if (DistanceToPlayer > 15f)
       {
           moveSpeed = farAwaySpeed;
       }
       else
       {
           moveSpeed = 2;
       }
   }

   private void EnemyTooFarAway()
   {
       float DistanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);
       if (DistanceToPlayer > 1000f)
       {
           Destroy(gameObject);
       }
   }
}
