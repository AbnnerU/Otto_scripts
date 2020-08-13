using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cachorro_seguir_menina2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Light luz;
    Vector3 garota;
 
    Vector3 posicao;
    bool detectou = false;
    Animator anim;
    Vector2 objeto;
    Vector2 player;
    float angulo;
    void Start()
    {
        luz = GameObject.Find("Lanterna").GetComponent<Light>();
        garota = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position;
        
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        posicao = transform.position;
        garota = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position;
        
        //animaçao
        objeto = transform.position;
        player = GameObject.Find("CharacterBody").transform.position;
        angulo = anguloObjetos(objeto, player);

        if (angulo >= 135 || angulo < -135)
        {
            anim.Play("Cachorro_correndo_esquerda");
        }
        else if (angulo >= -45 && angulo < 45)
        {
            anim.Play("Cachorro_correndo_direita");
        }

       
            transform.position = Vector3.MoveTowards(transform.position, garota, speed * Time.deltaTime);
        
       
        
        float anguloObjetos(Vector2 vec1, Vector2 vec2)
        {
            Vector2 diference = vec2 - vec1;
            float sign = (vec2.y < vec1.y) ? -1.0f : 1.0f;
            return Vector2.Angle(Vector2.right, diference) * sign;

        }
    }
}
