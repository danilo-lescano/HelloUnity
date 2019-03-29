using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultButton : MonoBehaviour{
    Collider2D[] colliders;
    SpriteRenderer SR;
    Color clickedColor, defaulfColor;
    bool flagClickOn;
    public event Action OnClicked = delegate { };
    void Awake(){
        colliders = GetComponents<Collider2D>();
        SR = GetComponent<SpriteRenderer>();
        clickedColor = new Color(0.784f, 0.784f, 0.784f, 1f);
        defaulfColor = new Color(1f, 1f, 1f, 1f);
        flagClickOn = false;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z =  transform.position.z;
            for (int i = 0; i < colliders.Length; i++)
                if(colliders[i].bounds.Contains(pos)){
                    SR.color = clickedColor;
                    flagClickOn = true;
                    break;
                }
        }
        else if(Input.GetMouseButtonUp(0)){
            SR.color = defaulfColor;
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z =  transform.position.z;
            for (int i = 0; i < colliders.Length; i++)
                if(flagClickOn && colliders[i].bounds.Contains(pos))
                    OnClicked();
            flagClickOn = false;
        }
    }
}