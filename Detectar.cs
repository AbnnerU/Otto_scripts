using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectar_X : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabParaAparecer;
     Vector2 posicao;
   
    private Vector2 alvo;
    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position;
        posicao = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name== "CharacterBody")
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefabParaAparecer);
            novoObjeto.transform.position = posicao; 
        }
    }
}
