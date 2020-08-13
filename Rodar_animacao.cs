using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodar_animacao : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    Light[] luzes_emergencia= new Light[14];
    Light[] luzes_gerador = new Light[17];
    GameObject[] luzes_piscando = new GameObject[4];
    int contador=2;
    GameObject Tela;
    Tela_morte telaMorte;
    Tempo tempo;
    AudioSource musica_fase;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        for (int i = 0; i < 17; i++)
        {
            luzes_gerador[i] = GameObject.Find("Luz_gerador (" + i + ")").GetComponent<Light>();
            luzes_gerador[i].enabled = false;
        }
        for (int i = 0; i < 14; i++)
        {
            luzes_emergencia[i] = GameObject.Find("luz_emergencia ("+i+")").GetComponent<Light>();
            luzes_emergencia[i].enabled = false;
        }
        for (int i = 0; i < 4; i++)
        {
            luzes_piscando[i] = GameObject.Find("Choquinho (" + i + ")");
            Destroy(luzes_piscando[i]);
        }
        if (GameObject.Find("Otto") != null)
        {
            Destroy(GameObject.Find("Otto"));
        }
        if (GameObject.Find("Otto_parado") != null)
        {
            Destroy(GameObject.Find("Otto_parado"));
        }
        Destroy(GameObject.Find("Objeto_para_Otto"));
        Tela = gameObject;
        telaMorte = Tela.GetComponent<Tela_morte>();
        tempo = GameObject.Find("TEMPO").GetComponent<Tempo>();
        musica_fase = GameObject.Find("fase").GetComponent<AudioSource>();
    }
     void Update()
    {
        anim.Play("Morcego_matando");
        telaMorte.matou = true;
        telaMorte.Monstro = 1;
        tempo.stop = true;
        musica_fase.enabled = false;
    }
    // Update is called once per frame

}
