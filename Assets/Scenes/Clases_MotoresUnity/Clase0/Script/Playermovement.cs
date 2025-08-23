using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class movement: MonoBehaviour
{

    public float velocity = 0.05f; //Velocidad de movimiento
    public int rotation = 17; //Velocidad de rotacion

    //Declaracion de Teclas. LAS ROTACIONES Y EL CAMBIO DE COLOR SON EDITABLES desde el inspector.
    //no se por que no se quedan predefinidas con el Keycode.
    public KeyCode keyUp = KeyCode.W;
    public KeyCode keyLeft = KeyCode.A;
    public KeyCode keyRight= KeyCode.D;
    public KeyCode keyDown = KeyCode.S;
    public KeyCode RotateRight = KeyCode.E;
    public KeyCode RotateLeft = KeyCode.Q;
    public KeyCode ChangeColor = KeyCode.R;

    private void Update()
    {
        //WASD, ROTACION DE PLAYERS Y CAMBIO DE COLOR

        if (Input.GetKey(keyUp))
        {
            transform.position = transform.position + new Vector3(0 , velocity , 0);
        }
        if (Input.GetKey(keyLeft))
        {
            transform.position = transform.position + new Vector3( -velocity , 0 , 0);
        }
        if (Input.GetKey(keyRight))
        {
            transform.position = transform.position + new Vector3( velocity, 0, 0 );
        }
        if (Input.GetKey(keyDown))
        {
            transform.position = transform.position + new Vector3(0, -velocity, 0);
        }

        if (Input.GetKey(RotateRight))
        {
            transform.Rotate(0, 0, rotation);
        }
        if (Input.GetKey(RotateLeft))
        {
            transform.Rotate(0, 0, -rotation);
        }

        if (Input.GetKey(ChangeColor)) 
        {
            GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }
    }
}

