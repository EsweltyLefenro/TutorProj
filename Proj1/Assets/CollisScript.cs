using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int score = 100;

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision works");
        score -= 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
