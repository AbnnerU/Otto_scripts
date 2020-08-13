using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otto_parado2 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 posicao;
    public GameObject prefab;
    public GameObject prefab2;
    Light target;
    Vector2 objeto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objeto = transform.position;
        target = GameObject.Find("Lanterna").GetComponent<Light>();
        posicao = transform.position;
        if (target.enabled == true)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = posicao;

        }
        if (GameObject.Find("Gerador_liga").GetComponent<BoxCollider2D>().enabled == false)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = objeto;
        }
    }
}
