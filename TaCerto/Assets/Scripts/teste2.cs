using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste2 : MonoBehaviour{
    /*void Start(){
        Texture2D texture = new Texture2D(128, 128);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, 128, 128), Vector2.zero);
        GetComponent<SpriteRenderer>().sprite = sprite;
     
        for (int y = 0; y < texture.height; y++){
            for (int x = 0; x < texture.width; x++){ //Goes through each pixel
                Color pixelColour;
                if (Random.Range(0, 2) == 1) //50/50 chance it will be black or white
                    pixelColour = new Color(0, 0, 0, 1);
                else
                    pixelColour = new Color(1, 1, 1, 1);
                texture.SetPixel(x, y, pixelColour);
            }
        }
        texture.Apply();
    }*/

    /*void Start(){
        Texture2D texture = new Texture2D(Screen.width, 16);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, Screen.width, 16), Vector2.zero);
        GetComponent<SpriteRenderer>().sprite = sprite;
     
        for (int y = 0; y < texture.height; y++){
            for (int x = 0; x < texture.width; x++){ //Goes through each pixel
                Color pixelColour;
                pixelColour = new Color(0, 0, 0, 0.5f);
                texture.SetPixel(x, y, pixelColour);
            }
        }
        texture.Apply();
        transform.position = new Vector2(
            Camera.main.ScreenToWorldPoint(
                new Vector2(Screen.width, 0f)).x*-1f,
            transform.position.y
        );
    }*/

    float tempo = 0f;
    public int wid, hei;

    void Start(){
    }

    void Update(){
        wid = Screen.width;
        hei = 22*Screen.height/36;
        tempo -= Time.deltaTime;
        if(tempo < 0f){
            Texture2D texture = new Texture2D(wid, hei);
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, wid, hei), Vector2.zero);
            GetComponent<SpriteRenderer>().sprite = sprite;
        
            for (int y = 0; y < texture.height; y++){
                for (int x = 0; x < texture.width; x++){ //Goes through each pixel
                    Color pixelColour;
                    if(Random.Range(0f, 1f) > 0.5f)
                        pixelColour = new Color(1f, 1f, 1f, 1f);
                    else
                        pixelColour = new Color(0f, 0f, 0f, 1f); 
                    texture.SetPixel(x, y, pixelColour);
                }
            }
            Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
            texture.Apply();
            transform.position = new Vector2(
                pos.x*-1f,
                pos.y*-1f
            );
            tempo = 0.2f;
        }
    }
}