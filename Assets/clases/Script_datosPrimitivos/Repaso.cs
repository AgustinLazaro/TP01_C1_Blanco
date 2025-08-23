//using System.Collections;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using UnityEngine;

//public class Repaso : MonoBehaviour
//{
//    //colecciones
//    int[] myarray = new[] { 333, 444, 555 };

//    private list<int> mylist = new list<int>();

//    private void Start()
//    {
//        mylist.add(1);
//        mylist.add(2);
//        mylist.add(3);
//    }
//    private dictionary<int, string> mydictionary = new dictionary<int, string>();
//    private object debug;

//    private void Start1()
//    {
//        mydictionary.add(1, "uno");
//        mydictionary.add(2, "dos");
//        mydictionary.add(3, "tres");
//    }


//    //operadores basicos
//    private void start()
//    {
//        int a = 10;
//        int b = 20;

//        //float c = 10.5f;
//        //double d = 10.5;
//        int suma = a + b;

//        if (a == b)
//        {
//            Debug.Log("son iguales");
//        }
//        else if (a < b)
//        {
//            Debug.Log("a es menor que b");
//        }
//        else if (a <= b)
//        {
//            Debug.Log("a es menor o igual que b");
//        }
//        else if (a >= b)
//        {
//            Debug.Log("a es mayor o igual que b");
//        }
//        else if (a != b)
//        {
//            Debug.Log("a es diferente de b");
//        }
//        else // if (a > b)
//        {
//            Debug.Log("a es mayor que b");
//        }

//    }

//    //operadores logicos
//    private void start2()
//    {
//        int a = 10;
//        int b = 20;
//        if (a == 10 && b == 20)
//        {
//            Debug.Log("a es igual a 10 y b es igual a 20");
//        }
//        else if (a == 10 || b == 20)
//        {
//            Debug.Log("a es igual a 10 o b es igual a 20");
//        }
//        else
//        {
//            Debug.Log("ninguna de las condiciones se cumple");
//        }
//    }

//    //operadores booleanos      
//    private void start3()
//    {
//        bool isTrue = true;
//        bool isFalse = false;
//        if (isTrue && !isFalse)
//        {
//            Debug.Log("isTrue es verdadero y isFalse es falso");
//        }
//        else if (isTrue || isFalse)
//        {
//            Debug.Log("al menos una de las condiciones es verdadera");
//        }
//        else
//        {
//            Debug.Log("ambas condiciones son falsas");
//        }

//    }
//    //operador switch
//    private void start4()



//    {
//        Weapon weapon = Weapon.Sword;
//        switch (weapon)
//        {
//            case Weapon.Sword:
//                Debug.Log("arma es una espada");
//                break;
//            case Weapon.Bow:
//                Debug.Log("arma es un arco");
//                break;
//            case Weapon.Axe:
//                Debug.Log("arma es un hacha");
//                break;
//            default:
//                Debug.Log("arma no reconocida");
//                break;
//        }
//    }
//    // Definir el enum Weapon con los valores necesarios
//    internal enum Weapon
//    {
//        Sword,
//        Bow,
//        Axe
//    }
//}



