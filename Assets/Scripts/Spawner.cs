using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _timer;
    public int randomNumber;
    private void Start()
    {
        _timer = 1.5f;
    }

    public virtual void SpawnObject()
    {
        switch (randomNumber)
        {
            case 0:
                Circle circle = CirclePool.Instance.Get();
                //circle.gameObject.transform.parent = parent.transform;
                circle.gameObject.transform.position = gameObject.transform.position;
                circle.gameObject.SetActive(true);
                break;
            case 1:
                Square square = SquarePool.Instance.Get();
                //square.gameObject.transform.parent = parent.transform;
                square.gameObject.transform.position = gameObject.transform.position;
                square.gameObject.SetActive(true);
                break;

        }
    }
   /* private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer<=0)
        {
            SpawnObject();
            _timer = Random.Range(1.5f, 3f);
        }
    }*/
}
