using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour{
public int mapWidth;
public int mapHeight;
public float xOrg;
public float yOrg;
public float scale = 10f;
 
public GameObject tSprite;
 
void Start()
    {
        CalcNoise();
    }
 
    void CalcNoise()
    {
        float y = 0.0F;
    while (y < mapHeight)
        {
            float x = 0.0F;
        while (x < mapWidth)
            {
                //Origin +
                float xCoord = xOrg + x / mapWidth * scale;
                float yCoord = yOrg + y / mapHeight * scale;
                float sample = Mathf.PerlinNoise(xCoord, yCoord);
 
                //Debug.Log (sample);
                Instantiate(tSprite, new Vector3(x, y), Quaternion.identity);
                x++;
            }
            y++;
        }
    }

}
