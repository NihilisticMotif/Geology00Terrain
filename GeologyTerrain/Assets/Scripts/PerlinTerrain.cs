using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinTerrain : MonoBehaviour
{
    //public float posX;
    //public float posY;
    //public float perlinNoise = 0f;
    public float[,] terrainHight;
    public int side=0;
    public float refine=0f;
    public float scale=0f;
    public float perlinNoise = 0f;
    Terrain terrain;
    // Start is called before the first frame update
    void Start()
    {
        terrainHight = new float[side, side];
        terrain = GetComponent<Terrain>();

        for (int i = 0; i < side; i++)
        {
            for(int j = 0; j < side; j++)
            {
                perlinNoise = Mathf.PerlinNoise(i * refine, j * refine);
                terrainHight[i, j] = perlinNoise * scale;
            }

        }
        terrain.terrainData.SetHeights(0, 0, terrainHight);
    }

    // Update is called once per frame
    void Update()
    {
        //perlinNoise = Mathf.PerlinNoise(posX, posY);
    }
}
