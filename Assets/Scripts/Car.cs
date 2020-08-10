using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public int StartingPos;
    public int Position;

    private void Start()
    {
        Position = StartingPos;
    }
}
