using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Asteroid;
    [SerializeField] private GameObject Enemy1;
    [SerializeField] private GameObject Enemy2;
    [SerializeField] private GameObject Enemy3;

    [SerializeField] private float AsteroidSpawnHeight;

    private GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SpawnWaves());
    }

    private IEnumerator SpawnWaves()
    {
        // Wave 1
        int AsteroidAnzahlWave1 = 3;
        int Enemy1AnzahlWave1 = 1;
       
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave1);
        SpawnEnemy1(Enemy1AnzahlWave1);
        
        // Wait for all enemies from Wave1 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);

        // Wave 2
        int AsteroidAnzahlWave2 = 5;
        int Enemy1AnzahlWave2 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave2);
        SpawnEnemy1(Enemy1AnzahlWave2);
        
        // Wait for all enemies from Wave2 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        //Wave 3
        int AsteroidAnzahlWave3 = 5;
        int Enemy1AnzahlWave3 = 1;
        int Enemy2AnzahlWave3 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave3);
        SpawnEnemy1(Enemy1AnzahlWave3);
        SpawnEnemy2(Enemy2AnzahlWave3);
        
        // Wait for all enemies from Wave3 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        //Wave4
        int AsteroidAnzahlWave4 = 5;
        int Enemy1AnzahlWave4 = 2;
        int Enemy2AnzahlWave4 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave4);
        SpawnEnemy1(Enemy1AnzahlWave4);
        SpawnEnemy2(Enemy2AnzahlWave4);
        
        // Wait for all enemies from Wave4 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        //Wave5
        int AsteroidAnzahlWave5 = 6;
        int Enemy1AnzahlWave5 = 2;
        int Enemy2AnzahlWave5 = 1;
        int Enemy3AnzahlWave5 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave5);
        SpawnEnemy1(Enemy1AnzahlWave5);
        SpawnEnemy2(Enemy2AnzahlWave5);
        SpawnEnemy3(Enemy3AnzahlWave5);
        
          
        // Wait for all enemies from Wave5 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave6 = 7;
        int Enemy1AnzahlWave6 = 3;
        int Enemy2AnzahlWave6 = 1;
        int Enemy3AnzahlWave6 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave6);
        SpawnEnemy1(Enemy1AnzahlWave6);
        SpawnEnemy2(Enemy2AnzahlWave6);
        SpawnEnemy3(Enemy3AnzahlWave6);
        
        // Wait for all enemies from Wave6 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave7 = 7;
        int Enemy1AnzahlWave7 = 3;
        int Enemy2AnzahlWave7 = 2;
        int Enemy3AnzahlWave7 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave7);
        SpawnEnemy1(Enemy1AnzahlWave7);
        SpawnEnemy2(Enemy2AnzahlWave7);
        SpawnEnemy3(Enemy3AnzahlWave7);
        
        // Wait for all enemies from Wave7 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave8 = 7;
        int Enemy1AnzahlWave8 = 3;
        int Enemy2AnzahlWave8 = 3;
        int Enemy3AnzahlWave8 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave8);
        SpawnEnemy1(Enemy1AnzahlWave8);
        SpawnEnemy2(Enemy2AnzahlWave8);
        SpawnEnemy3(Enemy3AnzahlWave8);
        
        // Wait for all enemies from Wave8 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave9 = 7;
        int Enemy1AnzahlWave9 = 5;
        int Enemy2AnzahlWave9 = 3;
        int Enemy3AnzahlWave9 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave9);
        SpawnEnemy1(Enemy1AnzahlWave9);
        SpawnEnemy2(Enemy2AnzahlWave9);
        SpawnEnemy3(Enemy3AnzahlWave9);
        
        // Wait for all enemies from Wave9 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave10 = 8;
        int Enemy1AnzahlWave10 = 0;
        int Enemy2AnzahlWave10 = 5;
        int Enemy3AnzahlWave10 = 0;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave10);
        SpawnEnemy1(Enemy1AnzahlWave10);
        SpawnEnemy2(Enemy2AnzahlWave10);
        SpawnEnemy3(Enemy3AnzahlWave10);
        
        // Wait for all enemies from Wave10 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave11 = 8;
        int Enemy1AnzahlWave11 = 5;
        int Enemy2AnzahlWave11 = 5;
        int Enemy3AnzahlWave11 = 0;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave11);
        SpawnEnemy1(Enemy1AnzahlWave11);
        SpawnEnemy2(Enemy2AnzahlWave11);
        SpawnEnemy3(Enemy3AnzahlWave11);
        
        // Wait for all enemies from Wave11 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave12 = 7;
        int Enemy1AnzahlWave12 = 6;
        int Enemy2AnzahlWave12 = 5;
        int Enemy3AnzahlWave12 = 0;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave12);
        SpawnEnemy1(Enemy1AnzahlWave12);
        SpawnEnemy2(Enemy2AnzahlWave12);
        SpawnEnemy3(Enemy3AnzahlWave12);
        
        // Wait for all enemies from Wave12 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave13 = 8;
        int Enemy1AnzahlWave13 = 4;
        int Enemy2AnzahlWave13 = 5;
        int Enemy3AnzahlWave13 = 1;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave13);
        SpawnEnemy1(Enemy1AnzahlWave13);
        SpawnEnemy2(Enemy2AnzahlWave13);
        SpawnEnemy3(Enemy3AnzahlWave13);
        
        // Wait for all enemies from Wave13 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave14 = 10;
        int Enemy1AnzahlWave14 = 2;
        int Enemy2AnzahlWave14 = 4;
        int Enemy3AnzahlWave14 = 2;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave14);
        SpawnEnemy1(Enemy1AnzahlWave14);
        SpawnEnemy2(Enemy2AnzahlWave14);
        SpawnEnemy3(Enemy3AnzahlWave14);
        
        // Wait for all enemies from Wave14 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave15 = 10;
        int Enemy1AnzahlWave15 = 3;
        int Enemy2AnzahlWave15 = 3;
        int Enemy3AnzahlWave15 = 3;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave15);
        SpawnEnemy1(Enemy1AnzahlWave15);
        SpawnEnemy2(Enemy2AnzahlWave15);
        SpawnEnemy3(Enemy3AnzahlWave15);
        
        // Wait for all enemies from Wave15 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave16 = 10;
        int Enemy1AnzahlWave16 = 6;
        int Enemy2AnzahlWave16 = 2;
        int Enemy3AnzahlWave16 = 3;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave16);
        SpawnEnemy1(Enemy1AnzahlWave16);
        SpawnEnemy2(Enemy2AnzahlWave16);
        SpawnEnemy3(Enemy3AnzahlWave16);
        
        // Wait for all enemies from Wave16 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);
        
        int AsteroidAnzahlWave17 = 10;
        int Enemy1AnzahlWave17 = 6;
        int Enemy2AnzahlWave17 = 4;
        int Enemy3AnzahlWave17 = 3;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave17);
        SpawnEnemy1(Enemy1AnzahlWave17);
        SpawnEnemy2(Enemy2AnzahlWave17);
        SpawnEnemy3(Enemy3AnzahlWave17);
    }

    private void SpawnAsteroids(GameObject enemyPrefab, int waveSize)
    {
        for (int j = 0; j < waveSize; j++)
        {
            float randomXOffset = Random.Range(-17f, 17f);
            Vector3 SpawnPoint = new Vector3(player.transform.position.x + randomXOffset, AsteroidSpawnHeight, player.transform.position.z);
            Instantiate(enemyPrefab, SpawnPoint, Quaternion.identity);
            
        }
    }

    private void SpawnEnemy1(int waveSize)
    {
        for (int i = 0; i < waveSize; i++)
        {
            Vector3 spawnOffset = GetRandomSpawnOffset();
            Vector3 spawnPosition = player.transform.position + spawnOffset;
            spawnPosition.z = 0f;
            Instantiate(Enemy1, spawnPosition, Quaternion.identity);
        }
    }

    private void SpawnEnemy2(int waveSize)
    {
        for (int i = 0; i < waveSize; i++)
        {
            float randomXOffset = Random.Range(-17f, 17f);
            Vector3 SpawnPoint = new Vector3(player.transform.position.x + randomXOffset, AsteroidSpawnHeight, 0f);
            Instantiate(Enemy2, SpawnPoint, Quaternion.identity);
        }
    }

    private void SpawnEnemy3(int waveSize)
    {

        //float minDistance = 5f;
       // float maxdistance = 15f;
        
        for (int i = 0; i < waveSize; i++)
        {
            float randomXOffset = Random.Range(-17f, 17f);
            Vector3 SpawnPoint = new Vector3(player.transform.position.x + randomXOffset, AsteroidSpawnHeight, 0f);
            Instantiate(Enemy3, SpawnPoint, Quaternion.identity);
        }
    }


    private Vector3 GetRandomSpawnOffset()
    {
        float SpawnDistance = 20f;

        Vector2 randomDirection = Random.insideUnitCircle.normalized;

        Vector3 spawnOffset = new Vector3(randomDirection.x, 0f, randomDirection.y) * SpawnDistance;
        return spawnOffset;
    }

    private Vector3 GetRandomSpawnOffsetForEnemy3()
    {
        float spawnAngel = Random.Range(0f, 360f);
        Vector2 randomDirection = new Vector2(Mathf.Cos(spawnAngel * Mathf.Deg2Rad), Mathf.Sin(spawnAngel * Mathf.Rad2Deg));
        return new Vector3(randomDirection.x, 0f, randomDirection.y);
    }
}
