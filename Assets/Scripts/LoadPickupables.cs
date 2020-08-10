using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPickupables : MonoBehaviour
{
    private float _timer;
    public Spawner[] allSpawners;
    void Start()
    {
        CirclePool.Instance.AddObjects(20);
        SquarePool.Instance.AddObjects(20);
        _timer = 1.5f;
    }
    private void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer <= 0f)
        {
            Detect();
            _timer = 2.5f;
        }

    }
    public void Detect()
    {
        allSpawners[0].randomNumber = Random.Range(0, 2);
        allSpawners[2].randomNumber = Random.Range(0, 2);
        if (allSpawners[0].randomNumber == 1)
        {
            allSpawners[1].randomNumber = 0;
        }
        else
        {
            allSpawners[1].randomNumber = 1;
        }

        if (allSpawners[2].randomNumber == 1)
        {
            allSpawners[3].randomNumber = 0;
        }
        else
        {
            allSpawners[3].randomNumber = 1;
        }
        foreach (Spawner spawner in allSpawners)
        {
            spawner.SpawnObject();
        }
    }
}
