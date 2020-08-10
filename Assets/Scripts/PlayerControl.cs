using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D _redCar, _greenCar;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    public void MoveRedCar()
    {
        if(_redCar.transform.position.x == -3.7f)
        {
            _redCar.position = new Vector2(-1.2f, _redCar.transform.position.y);
        }
        if (_redCar.transform.position.x == -1.2f)
        {
            _redCar.position = new Vector2(-3.7f, _redCar.transform.position.y);
        }
    }
    public void MoveGreenCar()
    {
        if (_greenCar.transform.position.x == 3.79f)
        {
            _greenCar.position = new Vector2(1.34f, _redCar.transform.position.y);
        }
        if (_greenCar.transform.position.x == 1.34f)
        {
            _greenCar.position = new Vector2(3.79f, _redCar.transform.position.y);
        }
    }
}
