﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;
    [SerializeField] float enemyMoveSpeed = 2f;

    [SerializeField] WaveConfig waveConfig;

    //puts the waypoint that we want to go
    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;

            targetPosition.z = 0f;

            var enemyMovement = enemyMoveSpeed * Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, targetPosition, enemyMovement);

            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
