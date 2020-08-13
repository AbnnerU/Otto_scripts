using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porta_verde : MonoBehaviour
{
    Animator anim;
    administrador_recursos administrador;
    BoxCollider2D colider1,colider2;
    bool colidindo = false;
    Text texto;
    Text texto2;
    AudioSource somPorta;
    GameObject luz;
    Luzinha luzinha;
    // Start is called before the first frame update
     void Start()
    {
        anim = GameObject.Find("porta verde_0").GetComponent<Animator>();
        administrador = GameObject.Find("ADMINISTRADOR DE RECUSOS").GetComponent<administrador_recursos>();
        colider1 = gameObject.GetComponent<BoxCollider2D>();
        colider2 = GameObject.Find("porta verde_0").GetComponent<BoxCollider2D>();
        texto = GameObject.Find("Fala").GetComponent<Text>();
        texto.enabled = false;
        texto2 = GameObject.Find("Text2").GetComponent<Text>();
        texto2.enabled = false;
        somPorta = GameObject.Find("ta aqui porra porta (1)").GetComponent<AudioSource>();
        luz = GameObject.Find("luz_porta_verde");
        luzinha = luz.GetComponent<Luzinha>();
    }
    void Update()
    {
        if (colidindo == true)
        {
            if (administrador.cartaoV == true)
            {
               
                if (Input.GetKeyDown(KeyCode.E))
                {
                    colider1.enabled = false;
                    colider2.enabled = false;
                    anim.Play("Porta_verde_abrindo");
                    somPorta.enabled = true;
                    luzinha.piscando = true;
                }
            }
            
        }
        
            
         
    }
    void OnGUI()
    {
        if (colidindo)
        {
            if (administrador.cartaoV == false)
            {
                texto.enabled = true;
            }
            if (administrador.cartaoV == true)
            {
                texto2.enabled = true;
            }

        }
        else
        {
                texto.enabled = false;
            texto2.enabled = false;

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "CharacterBody")
        {
            colidindo = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "CharacterBody")
        {
            colidindo = false;
        }
    }
}
