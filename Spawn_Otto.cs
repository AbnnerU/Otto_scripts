using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Otto : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempo;
    public GameObject prefabParaAparecer;
    public Vector2 posicao;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if (tempo < 0)
        {
            tempo = 0;

        }
            if (tempo == 0)
        {
            print("massa");
            GameObject novoObjeto = Instantiate<GameObject>(prefabParaAparecer);
            novoObjeto.transform.position = posicao;
            tempo = 1000;
        }

    }
}
