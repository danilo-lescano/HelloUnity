using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour{
    public BoardMatriz boardMatriz;
    void Start(){
        GetComponent<PieceManager>().OnNewPiece += CheckWinCondition;
    }
    void CheckWinCondition(){
        for (int i = 0; i < 3; i++){
            int xCol = 0, oCol = 0;
            for (int j = 0; j < 3; j++){
                if(boardMatriz.matriz[i,j] == 'X')
                    xCol++;
                if(boardMatriz.matriz[i,j] == 'O')
                    oCol++;
                print(i + "," + j + ":" + boardMatriz.matriz[i,j]);
            }
            if(xCol == 3)
                print("x win");
            if(oCol == 3)
                print("o win");
        }
    }
}
