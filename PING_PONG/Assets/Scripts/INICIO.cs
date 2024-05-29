using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class INICIO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }
    public void Credito()
    {
        SceneManager.LoadScene(2);
    }
    public void Sair()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
       
    }
    public void voltar()
    {
        SceneManager.LoadScene(0);
    }

}
