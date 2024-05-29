using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float Jogador1;
    public float Jogador2;
    public TextMeshProUGUI pontuacaoatu;
    public AudioSource pont;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pontuacaoJg1()
    {
        Jogador1++;
        pontuacaoAtu();
    }
    public void pontuacaoJg2()
    {
        Jogador2++;
        pontuacaoAtu();
    }
    public void pontuacaoAtu() 
    {
        pontuacaoatu.text = Jogador1 + "X" + Jogador2;
        pont.Play();
    }
}
