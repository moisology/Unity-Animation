using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mugWorks : MonoBehaviour
{
    public GameObject heldMug, tableMug;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        tableMug.SetActive(false);
        heldMug.SetActive(true);
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(t == 60) { SetMug(); }
        t++;
    }
    
    void SetMug()
    {
        heldMug.SetActive(false);
        tableMug.SetActive(true);
    }
}
