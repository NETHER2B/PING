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
    public GameObject Pause;
    public GameObject FIM;
    

    public int temporizador;
    public float tempcont;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
            
        txtTime.text = temporizador.ToString();
        tempcont += Time.deltaTime;
        temporizador = 60 - (int)tempcont;
        if(Input.GetKey(KeyCode.Escape))
        {
            pause();
        }
        if (temporizador == 0)
        {
            GameOver();
        }
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
        //pont.Play();
    }
    void pause()
    {
        Time.timeScale = 0;
        Pause.SetActive(true);
    }
    public void despause()
    {
        Time.timeScale = 1;
        Pause.SetActive(false);
    }
    public void GameOver()
    {
        
        
            Time.timeScale = 0;
            FIM.SetActive(true);
        
    }
}
