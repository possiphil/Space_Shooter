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
        int Enemy1Anzahl = 1;
       
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave1);
        SpawnEnemy1(Enemy1Anzahl);
        
        // Wait for all enemies from Wave1 to be destroyed
        yield return new WaitUntil(() => GameObject.FindGameObjectsWithTag("Enemy").Length == 0);

        // Wave 2
        int AsteroidAnzahlWave2 = 5;
        SpawnAsteroids(Asteroid, AsteroidAnzahlWave2);
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

            Instantiate(Enemy1, spawnPosition, Quaternion.identity);
        }
    }

    private void SpawnEnemy2(int waveSize)
    {
        for (int i = 0; i < waveSize; i++)
        {
            float randomXOffset = Random.Range(-17f, 17f);
            Vector3 SpawnPoint = new Vector3(player.transform.position.x + randomXOffset, AsteroidSpawnHeight, player.transform.position.z);
            Instantiate(Enemy2, SpawnPoint, Quaternion.identity);
        }
    }

    private void SpawnEnemy3(int waveSize)
    {

        float minDistance = 5f;
        float maxdistance = 15f;
        
        for (int i = 0; i < waveSize; i++)
        {
            float randomXOffset = Random.Range(-17f, 17f);
            Vector3 SpawnPoint = new Vector3(player.transform.position.x + randomXOffset, AsteroidSpawnHeight, player.transform.position.z);
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
