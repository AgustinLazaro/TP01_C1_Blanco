using UnityEngine;


public class Repaso2 : MonoBehaviour 
{     
    //clases y objetos
    public int a = 10;
    public int b = 20;

    private void Start()
    {
        if (a < b)
        {
            Debug.Log("a es menor que b");
        }
        
        else if  (a > b)
        {
            Debug.Log("a es mayor que b");
        }
        else
        {
            Debug.Log("a es igual que b");
        }
    }

}