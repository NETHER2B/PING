using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade;
    public float velocidadeATU;
    public float velocidadeATU2;
    private PlayersMov BL;
    public bool verificar;
    public float teste;
    public float testeATU;
    // Start is called before the first frame update

    void Start()
    {
        BL = FindObjectOfType(typeof(PlayersMov)) as PlayersMov;
      
        velocidadeATU = 4;
        velocidadeATU2 = 4;
      
       teste = 4;
    }

    // Update is called once per frame
    void Update()
    {
        teste += Time.deltaTime;
        Resp();
        if(verificar == false && teste > 2)

        {
            rb.velocity = new Vector2(velocidadeATU, velocidadeATU2);
            verificar = true;   
            teste = 0;

        }
    
  
    }   
    public void Resp()
    {
        if(transform.position.x >= 9.55f || transform.position.x <= -9.55f)
        {
            velocidadeATU = 4;
            print(velocidadeATU);
                
            transform.position = new Vector2(0,0);
            rb.velocity = new Vector2(4,4);
        } 
    }
    
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "JOGADOR")
        {
          
            verificar = false;
            velocidadeATU = + velocidadeATU* 1.2f;
           velocidadeATU = rb.velocity.x*1.2f;
            velocidadeATU2 = rb.velocity.y * 1.2f;
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //rb.velocity = new Vector2(1, 3);
    }

}
