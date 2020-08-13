using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liga_lanterna : MonoBehaviour
{
   
    private Light luz;
    PolygonCollider2D colider;
    // Start is called before the first frame update
    void Start()
    {
        luz = GetComponent<Light>();
        colider = GameObject.Find("Colider_luz").GetComponent<PolygonCollider2D>();
        colider.enabled = false;
        luz.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            luz.enabled = !luz.enabled;
            colider.enabled = !colider.enabled;
        }
    }
}
