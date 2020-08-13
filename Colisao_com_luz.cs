using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao_com_luz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    Vector2 posicao;
    AudioSource som;
    void Start()
    {
        som = GameObject.Find("Som_morcego").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Colider_luz")
        {
            som.enabled = true;
            som.Play();
            posicao = gameObject.transform.position;  
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = posicao;
        }
       
    }
}
