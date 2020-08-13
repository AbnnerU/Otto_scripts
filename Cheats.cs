using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cheats : MonoBehaviour
{
    // Start is called before the first frame update
    bool cheats = false, luz = false;
    BoxCollider2D player;
    Vector2 player_posicao;
     Camera camera,camera_principal;
    PolygonCollider2D colider_luz;
    private Light[] luzes = new Light[17];
    Text texto;
    void Start()
    {
        player = GameObject.Find("CharacterBody").GetComponent<BoxCollider2D>();
        player_posicao = GameObject.Find("CharacterBody").GetComponent<Transform>().transform.position;
        camera = GameObject.Find("Camera follow Variant").GetComponent<Camera>();
        camera_principal = GameObject.Find("Main Camera").GetComponent<Camera>();
        colider_luz = GameObject.Find("Colider_luz").GetComponent<PolygonCollider2D>();
        texto = GameObject.Find("CODIGOS").GetComponent<Text>();
        for (int i = 0; i < 17; i++)
        {
            luzes[i] = GameObject.Find("Luz_gerador (" + i + ")").GetComponent<Light>();

        }


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Y))
        {
            cheats = true;
            texto.enabled = true;
        }
         if (cheats == true)
        {
            if (Input.GetKey(KeyCode.U))
            {
                
                camera.enabled = true;
                camera_principal.enabled = false;
                player.enabled = false;
                colider_luz.enabled = false;
                Destroy(GameObject.Find("Main Camera"));
                
            }
            if (Input.GetKey(KeyCode.I))
            {
                luz = !luz;
                if (luz == true)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        luzes[i].enabled = true;

                    }
                }
                if (luz == false)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        luzes[i].enabled = false;

                    }
                }
            }
            if (Input.GetKey(KeyCode.O))
            {
                carregarNivel();
            }
            if (Input.GetKey(KeyCode.P))
            {
                carregarNivel1();
            }
        }
    }
    void carregarNivel()
    {
        SceneManager.LoadScene("tutorial");
    }
    void carregarNivel1()
    {
        SceneManager.LoadScene("Tela vitoria");
    }
}
