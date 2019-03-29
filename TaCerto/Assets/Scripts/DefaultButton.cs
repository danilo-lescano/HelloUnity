using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultButton : MonoBehaviour{
    Collider2D[] colliders;
    SpriteRenderer SR;
    float clickedColor, defaulfColor, actualColor;
    bool flagClickOn;
    public event Action OnClicked = delegate { };
    void Awake(){
        colliders = GetComponents<Collider2D>();
        SR = GetComponent<SpriteRenderer>();
        clickedColor = 0.784f;
        actualColor = defaulfColor = 1f;
        flagClickOn = false;
        OnClicked += hehe;
    }
    void hehe(){
        print("hehe");
    }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z =  transform.position.z;
            for (int i = 0; i < colliders.Length; i++)
                if(colliders[i].bounds.Contains(pos)){
                    flagClickOn = true;
                    break;
                }
        }
        else if(Input.GetMouseButtonUp(0)){
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z =  transform.position.z;
            for (int i = 0; i < colliders.Length; i++)
                if(flagClickOn && colliders[i].bounds.Contains(pos)){
                    OnClicked();
                    break;
                }
            flagClickOn = false;
        }

        RenderColorImage();
    }
    void RenderColorImage(){
        if(SR != null){
            float deltaColor = (defaulfColor - clickedColor) * Time.deltaTime * 5f;
            if(flagClickOn){
                if(actualColor > clickedColor)
                    actualColor -= deltaColor;
                if(actualColor < clickedColor)
                    actualColor = clickedColor;
            }
            else{
                if(actualColor > defaulfColor)
                    actualColor += deltaColor;
                if(actualColor < defaulfColor)
                    actualColor = defaulfColor;
            }
            SR.color = new Color(actualColor, actualColor, actualColor, 1f);
        }
    }
}