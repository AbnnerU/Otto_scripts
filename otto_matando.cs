using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otto_matando : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public GameObject prefab,prefab2;
    Vector3 esse_objeto;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    
    
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name == "CharacterBody")
            {
            esse_objeto = transform.position;
            Destroy(gameObject);
                
                Destroy(GameObject.Find("JoagdorMovimento"));
                GameObject novoObjeto = Instantiate<GameObject>(prefab);
                novoObjeto.transform.position = esse_objeto;
                novoObjeto.transform.position = new Vector3(novoObjeto.transform.position.x, novoObjeto.transform.position.y, -0.869f);
                GameObject novoObjeto2 = Instantiate<GameObject>(prefab2);
                novoObjeto2.transform.position = esse_objeto;



            }
        }
}
