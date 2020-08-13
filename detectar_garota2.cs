using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar_garota2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab, prefab1;
    Vector2 posicao;
    Vector3 esse_objeto;
    string objeto;
    void Start()
    {
        
        print(objeto);
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.collider.name == "CharacterBody")
        {
            posicao = transform.position;
            esse_objeto = transform.position;
            Destroy(GameObject.Find("JoagdorMovimento"));
            Destroy(GameObject.Find("Otto"));
            Destroy(gameObject);
            GameObject novoObjeto = Instantiate<GameObject>(prefab);
            novoObjeto.transform.position = posicao;
            GameObject novoObjeto1 = Instantiate<GameObject>(prefab1);
            novoObjeto1.transform.position = esse_objeto;
            novoObjeto1.transform.position = new Vector3(novoObjeto.transform.position.x, novoObjeto.transform.position.y - 0.8f, -0.869f);
        }
    }
}
