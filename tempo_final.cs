using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tempo_final : MonoBehaviour
{
    // Start is called before the first frame update
    Text tempo;
    public int minutes;
    public int seconds;
    public int milliseconds;
    void Start()
    {
        minutes = Global.Instance.minutes;
        seconds = Global.Instance.seconds;
        milliseconds = Global.Instance.milliseconds;
        tempo = gameObject.GetComponent<Text>();
        tempo.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
    }

    // Update is called once per frame
    
}
