using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOLA7 : MonoBehaviour
{
    public float velocity;
    public Rigidbody2D bolinha;
    public AudioSource somBall;
    void Start()
    {
        MovBolinha();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovBolinha()
    {
        bolinha.velocity = new Vector2(velocity,velocity)*Time.deltaTime;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        somBall.Play();
    }
}
