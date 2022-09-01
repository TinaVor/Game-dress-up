using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Audio : MonoBehaviour
{
    public void Song()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
