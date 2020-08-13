using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class porta_gerador : MonoBehaviour
{
    // Start is called before the first frame update
    bool colidindo = false;
    Text texto;
    BoxCollider2D colider;
    AudioSource somPorta;
    void Start()
    {
        texto = GameObject.Find("Texto_gerador").GetComponent<Text>();
        texto.enabled = false;
        colider = gameObject.GetComponent<BoxCollider2D>();
        somPorta = GameObject.Find("ta aqui porra porta (2)").GetComponent<AudioSource>();
    }
     void Update()
    {
        if (GameObject.Find("Gerador_liga").GetComponent<BoxCollider2D>().enabled == false)
        {
            colider.enabled = false;
            somPorta.enabled = true;
        }
    }

    void OnGUI()
    {
        if (colidindo)
        {
            texto.enabled = true;

        }
        else
        {
            texto.enabled = false;
           

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
