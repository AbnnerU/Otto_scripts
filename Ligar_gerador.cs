using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ligar_gerador : MonoBehaviour
{
    // Start is called before the first frame update
    bool colidindo = false, ligar=false;
    private Light[] luzes = new Light[17];
    Text texto;
    Animator anim;
    BoxCollider2D colider;
    AudioSource som;
    public AudioClip novoSom;
    Light[] luzes_emergencia = new Light[14];
    void Start()
    {
        texto = GameObject.Find("Text").GetComponent<Text>();
        texto.enabled = false;
        anim = GameObject.Find("gerador(Clone)").GetComponent<Animator>();
        anim.Play("Gerador_desligado");
        colider = gameObject.GetComponent<BoxCollider2D>();
        som = GameObject.Find("fase").GetComponent<AudioSource>();
        for (int i = 0; i < 17; i++)
        {
            luzes[i] = GameObject.Find("Luz_gerador ("+i+")").GetComponent<Light>();
           
        }
       
    }

    // Update is called once per frame
     void Update()
    {
        
        if (colidindo)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                for (int i = 0; i < 16; i++)
                {
                    luzes[i].enabled = true;
                    print(luzes[i]);
                }
                for (int i = 0; i < 14; i++)
                {
                    luzes_emergencia[i] = GameObject.Find("luz_emergencia (" + i + ")").GetComponent<Light>();
                    luzes_emergencia[i].enabled = false;
                }
                som.clip = novoSom;
                som.Play();
                colider.enabled = false;
                anim.Play("Gerador_ligado");
            }

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
