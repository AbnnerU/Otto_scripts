using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crianca_ponto : MonoBehaviour
{
    GameObject texto;
    Pontos a;
    AudioSource som;
    void Start()
    {
        texto = GameObject.Find("CRIANCAS");
        a = texto.GetComponent<Pontos>();
        som = GameObject.Find("Som_criancas").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "CharacterBody")
        {
            som.enabled = true;
            som.Play();
            Destroy(gameObject);
            a.ponto++;
        }
    }
}
