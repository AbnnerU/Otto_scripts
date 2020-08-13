using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Vitoria : MonoBehaviour
{
    // Start is called before the first frame update
    Tempo tempo;
    void Start()
    {
        tempo = GameObject.Find("TEMPO").GetComponent<Tempo>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name== "CharacterBody")
        {
            
            carregarNivel();
        }
    }
    void carregarNivel()
    {
        tempo.stop = true;
        SceneManager.LoadScene("Tela vitoria");
    }
}
