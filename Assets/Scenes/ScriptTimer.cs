﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTimer : MonoBehaviour
{
    public Text contador;
    public Text tickstext;
    public static float ticks = 0;
    public void GetTime() {ticks = tiempo;}
    private float tiempo = 0f;

    // Start is called before the first frame update
    void Start(){
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");
        GetTime();
        tickstext.text = " " + ticks.ToString("f0");

    }
}
