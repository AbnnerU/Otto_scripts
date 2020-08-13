using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otto_parado : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 posicao;
    public GameObject prefab;
    Light target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Lanterna").GetComponent<Light>();
        posicao = transform.position;
        if (target.enabled==false)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = posicao;

        }
    }
}
