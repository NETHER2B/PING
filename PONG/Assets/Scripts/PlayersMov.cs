using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMov : MonoBehaviour
{
    public float speed;
    public bool Jogador1;
    public bool Jogador2;
    public float limiteinf, limitesup;
    public float velocidade;
    public float temporizador;
    private Bolinha BAll;    // Start is called before the first frame update
    void Start()
    {
       
        BAll = FindObjectOfType(typeof(Bolinha)) as Bolinha;
    }

    // Update is called once per frame
    void Update()
    {
        if(Jogador1 == true)
        {
            Playermov1();
        }
        if(Jogador1 == false)
        {
            Playermov2();
        }
    }
    public void Playermov1()
    {
        transform.position = new Vector2(transform.position.x,Mathf.Clamp(transform.position.y, limiteinf, limitesup));
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
    public void Playermov2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteinf, limitesup));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
    }
  
    
}
