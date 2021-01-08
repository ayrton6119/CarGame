using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfigList;

    int startingWave = 0;

    void Start()
    {
        var currentWave = waveConfigList[startingWave];

        StartCoroutine(SpawnAllEnemiesWave(currentWave));
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnAllEnemiesWave(WaveConfig waveConfig)
    {
        Instantiate(
            waveConfig.GetEnemyPrefab(),
            waveConfig.GetWaypoints()[0].transform.position,
            Quaternion.identity);
        yield return new WaitForSeconds(waveConfig.GetTimeBetweenSpawns());
    }
}