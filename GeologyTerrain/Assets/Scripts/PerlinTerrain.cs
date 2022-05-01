using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinTerrain : MonoBehaviour
{
    public float posX;
    public float posY;
    public float perlinNoise = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        perlinNoise = Mathf.PerlinNoise(posX, posY);
    }
}
