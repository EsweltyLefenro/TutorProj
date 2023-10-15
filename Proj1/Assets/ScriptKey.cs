using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Object;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Object acivated");
            Object.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Object deacivated");
            Object.SetActive(false);
        }
    }
}
