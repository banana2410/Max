using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : Pickupable, ICanBePickedUp
{
    public ScriptableEvent GameOverEvent;
    private Rigidbody2D _rb;
   // public GameObject GameOverScreen;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("feafgewa");
            Time.timeScale = 0f;
            GameOverEvent.RaiseEvent();
        }
    }
    private int _speed;
    public void OnPickup()
    {
        SquarePool.Instance.ReturnToPool(this);
    }
    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        //GameOverScreen = GameObject.FindObjectOfType<SceneChange>().gameObject;
        _speed = 4;
    }
    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + Vector2.down * Time.fixedDeltaTime * _speed);
    }
    private void Update()
    {
        if (transform.position.y < -300f)
        {
            SquarePool.Instance.ReturnToPool(this);
        }
    }

}
