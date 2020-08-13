using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cachorro_matando : MonoBehaviour
{
    private Animator anim;
    public GameObject prefab, prefab1;
    Vector3 esse_objeto;
    Vector2 posicao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        esse_objeto = transform.position;
        if (collision.gameObject.name == "CharacterBody")
        {
            posicao = gameObject.transform.position;
            esse_objeto = transform.position;
            Destroy(gameObject);
            Destroy(GameObject.Find("JoagdorMovimento"));
            Destroy(GameObject.Find("Otto"));


            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = esse_objeto;
            GameObject novoObjeto1 = Instantiate<GameObject>(prefab1);
            novoObjeto1.transform.position = esse_objeto;
            novoObjeto1.transform.position = new Vector3(novoObjeto.transform.position.x, novoObjeto.transform.position.y-0.8f, -0.869f);
        }
    }
}