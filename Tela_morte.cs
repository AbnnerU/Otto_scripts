using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela_morte : MonoBehaviour
{
    public bool matou=false;
    public int Monstro;
    float tempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (matou==true && Monstro==0)//Planta
        {
            tempo += Time.deltaTime;
            
            if (tempo >=2.2f)
            {
                carregarNivel();
                matou = false;
            }
        }
        if (matou == true && Monstro == 1)//Morcego
        {
            tempo += Time.deltaTime;

            if (tempo >= 3f)
            {
                carregarNivel();
                matou = false;
            }
        }
        if (matou == true && Monstro == 2)//Otto
        {
            tempo += Time.deltaTime;

            if (tempo >= 6.8f)
            {
                carregarNivel();
                matou = false;
            }
        }
        if (matou == true && Monstro == 3)//cachorro
        {
            tempo += Time.deltaTime;

            if (tempo >= 2.2f)
            {
                carregarNivel();
                matou = false;
            }
        }

    }
    void carregarNivel()
    {

        SceneManager.LoadScene("Tela Derrota");
    }
}
