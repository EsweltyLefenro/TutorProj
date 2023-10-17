using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text CounterText;
    public CollisScript CollisScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CounterText.text = "Counter: " + CollisScript.score;
    }
}
