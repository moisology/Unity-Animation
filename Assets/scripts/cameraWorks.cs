using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraWorks : MonoBehaviour
{
    // 0 : seat shot
    // 1 : front shot
    // 2 : side shot
    // 3 : window shot
    // 4 : road shot

    public GameObject[] cams = new GameObject[5];
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        SetShot(0);
    }

    // Update is called once per frame
    void Update()
    {
        switch (t)
        {
            case 26: SetShot(1); break;
            case 95: SetShot(2); break;
            case 130: SetShot(3); break;
            case 150: SetShot(1); break;
            case 220: SetShot(4); break;
        }
        t++;
    }

    void SetShot(int index)
    {
        for(int i = 0; i < 5; i++)
        {
            if(i != index){ cams[i].SetActive(false); }
        }
        cams[index].SetActive(true);
    }

}
