using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Jogador1;
    public float Jogador2;
    public TextMeshProUGUI pontuacaoatu;
    public AudioSource pont;
    public TextMeshProUGUI txtTime;
    

    public int temporizador;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txtTime.text = temporizador.ToString();
        temporizador = 60 - (int)Time.time;
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
    void pause()
    {
        Time.timeScale = 0;
    }
}
