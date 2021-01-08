using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    //the enemy to spawn
    [SerializeField] GameObject enemyPrefab;
    //the path on which the wave will move 
    [SerializeField] GameObject pathPrefab;
    //time between each Enemy spawn
    [SerializeField] float timeBetweenSpawns = 0.5f;
    //random differnece between spawns
    [SerializeField] float spawnRandomFactor = 0.3f;
    //number of enemies I have 
    [SerializeField] int numberOfEnemies = 5;
    //enemy movemoent speed
    [SerializeField] float enemyMoveSpeed = 2f;

    //encapsulation methods
    public GameObject GetEnemyPrefab()
    {
        return enemyPrefab;
    }

    public List<Transform> GetWaypoints()
    {
        //each wave we can have differnet number of waypoints
        var waveWaypoints = new List<Transform>();

        //go into path prefab and for each child, add it to the List
        foreach (Transform child in pathPrefab.transform)
        {
            waveWaypoints.Add(child);
        }

        return waveWaypoints;

    }

    public float GetTimeBetweenSpawns()
    {
        return timeBetweenSpawns;
    }

    public float GetSpawnRandomFactor()
    {
        return spawnRandomFactor;
    }

    public int GetNumberOfEnemies()
    {
        return numberOfEnemies;
    }

    public float GetEnemyMoveSpeed()
    {
        return enemyMoveSpeed;
    }
}