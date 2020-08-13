using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar_garota : MonoBehaviour
{
    public GameObject prefabParaAparecer;
     Vector2 posicao;
    void Start()
    {
        
    }
     

    private void OnTriggerEnter2D(Collider2D collision)
    {
        posicao = transform.position; 
        if (collision.gameObject.name == "Colider_luz")
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefabParaAparecer);
            novoObjeto.transform.position = posicao;

        }
    }
}
