using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour{
    public BoolVariable turn;
    public BoardMatriz boardMatriz;
    public GameObject O, X;

    void Awake(){
        turn.value = Random.value > 0.5f ? true : false;
        boardMatriz.matriz = new bool[3,3];
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int[] posMatriz = new int[2]{pos.x >= 1.425f ? 2 : pos.x <= -1.425f ? 0 : 1, pos.y >= 1.425f ? 2 : pos.y <= -1.425f ? 0 : 1};

            if(!boardMatriz.matriz[posMatriz[0], posMatriz[1]]){
                GameObject go = GameObject.Instantiate(
                    turn.value ? O : X,
                    transform
                );

                go.transform.position = new Vector3(
                    pos.x >= 1.425f ? 2.85f : pos.x <= -1.425f ? -2.85f : 0f,
                    pos.y >= 1.425f ? 2.85f : pos.y <= -1.425f ? -2.85f : 0f,
                    0f);
                turn.value = !turn.value;
                boardMatriz.matriz[pos.x >= 1.425f ? 2 : pos.x <= -1.425f ? 0 : 1,
                pos.y >= 1.425f ? 2 : pos.y <= -1.425f ? 0 : 1] = true;
            }
        }
    }
}