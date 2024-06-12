using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PONTUAR : MonoBehaviour
{
    private GameManager GM;
    void Start()
    {
        GM = FindObjectOfType(typeof(GameManager)) as GameManager;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            GM.pontuacaoJg1();
            collision.gameObject.transform.position = Vector2.zero;
        }
    }
}
