using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    public GameObject prefabParaAparecer;
     Vector2 posicao;
    void Update()
    {
        if (GameObject.Find("Gerador_liga").GetComponent<BoxCollider2D>().enabled == false)
        {
            Destroy(gameObject);
            

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        posicao = transform.position;
        if(collision.gameObject.name== "CharacterBody")
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefabParaAparecer);
            novoObjeto.transform.position = posicao;
            
        }
    }
}
