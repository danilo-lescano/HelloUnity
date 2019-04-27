using UnityEngine;

[CreateAssetMenu(menuName = "Miscellaneous/BoardMatriz")]
public class BoardMatriz : ScriptableObject{
    public char[,] matriz;

    public void Awake(){
        Debug.Log("Awake");
    }

    public void OnEnable(){
        Debug.Log("OnEnable");
        matriz = new char[3,3];
    }

    public void OnDisable(){
        Debug.Log("OnDisable");
    }

    public void OnDestroy(){
        Debug.Log("OnDestroy");
    }
}