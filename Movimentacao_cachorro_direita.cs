using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_cachorro_direita : MonoBehaviour
{
    float Speed = 1.0f, limite = 1;
    public GameObject cachorroesquerda;
    private Vector3 pos;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        pos = transform.position;
        anim.Play("Cachorro_andando_direita");
        limite = limite + Time.deltaTime;

        if (limite > 15)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(cachorroesquerda);
            novoObjeto.transform.position = pos;

        }

        movimento();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.name != "CharacterBody")
        {
           
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(cachorroesquerda);
            novoObjeto.transform.position = pos;

        }
    }
    void movimento()
    {
        

       
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
          
    }

}
