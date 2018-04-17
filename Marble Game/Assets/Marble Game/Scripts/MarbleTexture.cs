using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleTexture : MonoBehaviour {

    public Material ball1;
    public Material ball2;
    public Material ball3;
    public Material ball4;

    MeshRenderer my_renderer;

    public void button1()
    {
        my_renderer = GetComponent<MeshRenderer>();
        my_renderer.material = ball1;
    }

    public void button2()
    {
        my_renderer = GetComponent<MeshRenderer>();
        my_renderer.material = ball2;
    }

    public void button3()
    {
        my_renderer = GetComponent<MeshRenderer>();
        my_renderer.material = ball3;
    }

    public void button4()
    {
        my_renderer = GetComponent<MeshRenderer>();
        my_renderer.material = ball4;
    }
}
