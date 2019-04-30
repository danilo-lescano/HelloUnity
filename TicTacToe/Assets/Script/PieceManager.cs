using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour{
    public BoolVariable turn;
    public BoardMatriz boardMatriz;
    public GameObject O, X;
    public event Action OnNewPiece = delegate {};

    void Awake(){
        turn.value = UnityEngine.Random.value >= 0.5f ? true : false;
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if(Physics.Raycast(ray, out hit, 100.0f)) {
                Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
            }


            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int[] posMatriz = new int[2]{
                pos.x >= 1.425f ? 2 : pos.x <= -1.425f ? 0 : 1,
                pos.y >= 1.425f ? 2 : pos.y <= -1.425f ? 0 : 1
            };
            print(pos.x + ":" + pos.y);
            if(boardMatriz.matriz[posMatriz[0], posMatriz[1]] == '\0'){
                GameObject go = GameObject.Instantiate(
                    turn.value ? O : X,
                    transform
                );

                go.transform.position = new Vector3(
                    pos.x >= 1.425f ? 2.85f : pos.x <= -1.425f ? -2.85f : 0f,
                    pos.y >= 1.425f ? 2.85f : pos.y <= -1.425f ? -2.85f : 0f,
                    -1f);
                boardMatriz.matriz[posMatriz[0], posMatriz[1]] = turn.value ? 'O' : 'X';
                turn.value = !turn.value;
                OnNewPiece();
            }
        }
    }
}