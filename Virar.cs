using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virar : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
     float tempo=1;
    public float limite;
    public GameObject prefab;
    Vector3 posicao;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        posicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        tempo = tempo + Time.deltaTime;
        print(tempo);
        anim.Play("Planta_escondendo1");
        if (tempo > limite)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = posicao;
        }
        
    }
   
}
