using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao_com_luz_planta : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D colider;
    GameObject objeto;
    public GameObject prefab,prefab2;
    Vector3 posicao;



    void Start()
    {
        posicao = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Gerador_liga").GetComponent<BoxCollider2D>().enabled == false)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab2);
            novoObjeto.transform.position = posicao;

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Colider_luz")
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = posicao;

        }

    }
   
    
}

