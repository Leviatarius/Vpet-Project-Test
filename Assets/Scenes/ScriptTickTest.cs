using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTickTest : MonoBehaviour
{ public static float ticktest;
    public Text ticktesttext;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        ticktest = ScriptTimer.ticks;
        ticktesttext.text = " " + ticktest.ToString("f0");
    }
}
