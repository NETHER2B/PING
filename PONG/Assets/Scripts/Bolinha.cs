using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(velocidade,velocidade);
    }

    // Update is called once per frame
    void Update()
    {
        Resp();
    }
    public void Resp()
    {
        if(transform.position.x >= 9.55f || transform.position.x <= -9.55f)
        {
            rb.velocity = new Vector2(velocidade, velocidade);
            transform.position = new Vector2(0,0);
        } 
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "JOGADOR")
        {
            rb.velocity = rb.velocity * 1.2f;
        }
    }
}
