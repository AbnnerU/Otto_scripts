using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_criança : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] pontosDeSpawn = new GameObject[15];
    GameObject novoObjeto;
   
    int Rand;
    int tamanho;
    List<int> list = new List<int>();
    public GameObject prefabDaCrianca0;
    public GameObject prefabDaCrianca1;
    public GameObject prefabDaCrianca2;
    public GameObject prefabDaCrianca3;
    int crianca;

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {

            pontosDeSpawn[i] = GameObject.Find("SpawCrianca (" + i + ")");

        }


        tamanho = pontosDeSpawn.Length;

        list = new List<int>(new int[tamanho]);

         for (int j = 0; j < 9; j++)
        {
            Rand = Random.Range(0, tamanho );

            while (list.Contains(Rand))
            {
                Rand = Random.Range(0, tamanho );
            }
            list[j] = Rand;
            crianca = Random.Range(0, 4);
            
            if (crianca == 0)
            {
                GameObject novoObjeto = Instantiate<GameObject>(prefabDaCrianca0);
                novoObjeto.transform.position = pontosDeSpawn[list[j]].transform.position;
            }
            if (crianca == 1)
            {
                GameObject novoObjeto = Instantiate<GameObject>(prefabDaCrianca1);
                novoObjeto.transform.position = pontosDeSpawn[list[j]].transform.position;
            }
            if (crianca == 2)
            {
                GameObject novoObjeto = Instantiate<GameObject>(prefabDaCrianca2);
                novoObjeto.transform.position = pontosDeSpawn[list[j]].transform.position;
            }
            if (crianca == 3)
            {
                GameObject novoObjeto = Instantiate<GameObject>(prefabDaCrianca3);
                novoObjeto.transform.position = pontosDeSpawn[list[j]].transform.position;
            }


        }

    }
}
