﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaçao_matando : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public GameObject prefab;
    Vector3 esse_objeto;
    //destruir luzes
    Light[] luzes_emergencia = new Light[14];
    Light[] luzes_gerador = new Light[17];
    GameObject[] luzes_piscando = new GameObject[4];
    int contador = 2;
    GameObject Tela;
    Tela_morte telaMorte;
    Tempo tempo;
    AudioSource musica_fase;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        esse_objeto = transform.position;
        Tela = gameObject;
        telaMorte = Tela.GetComponent<Tela_morte>();
        musica_fase = GameObject.Find("fase").GetComponent<AudioSource>();
        tempo = GameObject.Find("TEMPO").GetComponent<Tempo>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.name == "CharacterBody")
        {
            //destruir luzes
            for (int i = 0; i < 17; i++)
            {
                luzes_gerador[i] = GameObject.Find("Luz_gerador (" + i + ")").GetComponent<Light>();
                luzes_gerador[i].enabled = false;
            }
            for (int i = 0; i < 14; i++)
            {
                luzes_emergencia[i] = GameObject.Find("luz_emergencia (" + i + ")").GetComponent<Light>();
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
          
            Destroy(GameObject.Find("JoagdorMovimento"));
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = esse_objeto;
            novoObjeto.transform.position = new Vector3(novoObjeto.transform.position.x, novoObjeto.transform.position.y, -0.869f);
            tempo = GameObject.Find("TEMPO").GetComponent<Tempo>();
            anim.Play("Planta_matando");
            telaMorte.matou = true;
            telaMorte.Monstro = 0;
            tempo.stop = true;
            musica_fase.enabled = false;
        }
         
    }
   
}
