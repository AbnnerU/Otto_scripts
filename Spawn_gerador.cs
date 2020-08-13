using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_gerador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabDoGerador;
    private GameObject[] pontosDeSpawn = new GameObject[3];
    private Light[] luzes = new Light[17];
    int Rand;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
           
            pontosDeSpawn[i] = GameObject.Find("SpanwGerador ("+ i +")");
            
        }
        Rand = Random.Range(0, 3);
        print(Rand);

        GameObject novoObjeto = Instantiate<GameObject>(prefabDoGerador);
        novoObjeto.transform.position = pontosDeSpawn[Rand].transform.position;
        

    }

    
}
    
