using UnityEngine;

public class Repaso : MonoBehaviour 
{
    public int a = 0;
    public int b = 0;

    private void Start()
    {
        if (a > b) 
        {
          Debug.Log("A es mayor que B");
        }
        else if (a < b)
        {
          Debug.Log("B es mayor que A");
        }
        else
        {
            Debug.Log("SON IGUALES");
        }

    }



}

