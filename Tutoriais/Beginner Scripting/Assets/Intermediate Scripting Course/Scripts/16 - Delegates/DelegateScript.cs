using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour{
    delegate void MyDelegate_one();
    MyDelegate_one myDelegate_one;

    delegate void MyDelegate_two(int a);
    MyDelegate_two myDelegate_two;

    delegate void MyDelegate_three(int a, int b);
    MyDelegate_three myDelegate_three;

    delegate int MyDelegate_four();
    MyDelegate_four myDelegate_four;

    delegate (int, int) MyDelegate_five();
    MyDelegate_five myDelegate_five;

    delegate int MyDelegate_six(bool a);
    MyDelegate_six myDelegate_six;

    void Start(){
        myDelegate_one = method_one;
        myDelegate_two = method_two;
        myDelegate_three = method_three;
        myDelegate_four = method_four;
        myDelegate_five = method_five;
        myDelegate_six = method_six;
        myDelegate_five += method_seven;

        print("DELEGATE 1----------------");
        myDelegate_one();
        print("DELEGATE 2----------------");
        myDelegate_two(1);
        print("DELEGATE 3----------------");
        myDelegate_three(1, 2);
        print("DELEGATE 4----------------");
        myDelegate_four();
        print("DELEGATE 5----------------");
        myDelegate_five();
        print("DELEGATE 6----------------");
        myDelegate_six(true);
    }

    void method_one(){ print("method_one"); }

    void method_two(int a){ print("method_two"); }

    void method_three(int a, int b){ print("method_three"); }

    int method_four(){ print("method_four"); return 1; }

    (int, int) method_five(){ print("method_five"); return (1, 2); }

    int method_six(bool a){ print("method_six"); return 1; }

    (int, int) method_seven(){ print("method_seven"); return (1, 2); }
}