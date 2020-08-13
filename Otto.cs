using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otto : MonoBehaviour
{
   
    Vector2 player;
    float angulo;
    Animator anim;

    float speed;
    private Transform target;
    Vector2 objeto;
    public GameObject prefab;
  
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        target = GameObject.Find("CharacterBody").GetComponent<Transform>();
        speed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //animaçao
        objeto = transform.position;
        player = GameObject.Find("CharacterBody").transform.position;
        angulo = anguloObjetos(objeto, player);
        if (angulo >= 45 && angulo < 135)
        {
            anim.Play("Otto_costas");
        }
        else if (angulo >= 135 || angulo < -135)
        {
            anim.Play("Otto_esquerda");
        }
        else if (angulo >= -135 && angulo < -45)
        {
            anim.Play("Otto_frente");
        }
        else if (angulo >= -45 && angulo < 45)
        {
            anim.Play("Otto_direita");
        }

        //----------------------
        if (GameObject.Find("Gerador_liga").GetComponent<BoxCollider2D>().enabled == false)
        {
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = objeto;
        }
        if (GameObject.Find("Lanterna").GetComponent<Light>().enabled == true) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
       }

    }
    float anguloObjetos(Vector2 vec1, Vector2 vec2)
    {
        Vector2 diference = vec2 - vec1;
        float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
        return Vector2.Angle(Vector2.right, diference) * sign;

    }

}


