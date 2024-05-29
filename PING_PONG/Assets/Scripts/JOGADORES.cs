using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class JOGADORES : MonoBehaviour
{
   public float Velocity;
    public bool Jogador1;
    public float limiteSup;
    public float limiteInf;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Jogador1 ==  true)
        {
            JogadorMov1();
        }
        if (Jogador1 == false)
        {
            JogadorMov2();
        }


    }
    public void JogadorMov1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y,limiteInf, limiteSup));
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Velocity * Time.deltaTime);
        }


    }
    public void JogadorMov2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteInf, limiteSup));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Velocity * Time.deltaTime);
        }


    }
}
