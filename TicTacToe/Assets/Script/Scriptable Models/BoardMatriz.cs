using UnityEngine;

[CreateAssetMenu(menuName = "Miscellaneous/BoardMatriz")]
public class BoardMatriz : ScriptableObject{
    public char[,] matriz;

    public void OnEnable(){
        matriz = new char[3,3];
    }
}