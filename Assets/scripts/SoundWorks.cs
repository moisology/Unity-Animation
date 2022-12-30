using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWorks : MonoBehaviour
{
    // 0 : chair
    // 1 : sip
    // 2 : mug
    // 3 : sniff

    public AudioSource[] sounds = new AudioSource[4];
    float t;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (t)
        {
            case 10: PlaySound(0); break;
            case 30: PlaySound(1); break;
            case 60: PlaySound(2); break;
            case 218: PlaySound(3); break;
        }
        t++;
    }

    void PlaySound(int i)
    {
        sounds[i].Play();
    }
}
