using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour, ICanBePickedUp
{
    public ScriptableEvent GameOverEvent;
    private Rigidbody2D _rb;
   // public GameObject GameOverScreen;
    private Score _score;
    private int _speed;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            OnPickup();
        }
        if (collision.gameObject.tag == "EditorOnly")
        {
            Debug.Log("Go");
            Time.timeScale = 0f;
            GameOverEvent.RaiseEvent();
        }
    }
    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        //GameOverScreen = GameObject.FindObjectOfType<SceneChange>().gameObject;
        _speed = 4;
    }
    private void Update()
    {
        if(transform.position.y < -300f)
        {
            CirclePool.Instance.ReturnToPool(this);
        }
    }
    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + Vector2.down *Time.fixedDeltaTime* _speed);
    }
    public void OnPickup()
    {
        _score.ChangeScore();
        CirclePool.Instance.ReturnToPool(this);

    }
}
