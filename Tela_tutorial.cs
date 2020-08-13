using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tela_tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    Text texto;
    bool colidindo = false;
    void Start()
    {
        texto = GameObject.Find("Texto tutorial").GetComponent<Text>();
        texto.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
