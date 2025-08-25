using UnityEngine;

public class movement: MonoBehaviour
{

    public float velocity = 0.05f; //Velocidad de movimiento
    public int rotation = 17; //Velocidad de rotacion

    //Declaracion de Teclas. LAS ROTACIONES Y EL CAMBIO DE COLOR SON EDITABLES desde el inspector.
    //no se por que no se quedan predefinidas con el Keycode.
    public KeyCode keyUp;
    public KeyCode keyLeft;
    public KeyCode keyRight;
    public KeyCode keyDown;
    public KeyCode RotateRight;
    public KeyCode RotateLeft;
    public KeyCode ChangeColor;

    void Update()
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

