using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flip : MonoBehaviour
{
    public Joystick joystickLeft, joystickRight;
    
    float velocidade;
    void Start()
    {
        velocidade = 0.15f;        
    }

    
    void Update()
    {
        if (!Stone.isPause)
        {
            if (joystickLeft.Horizontal != 0)
            {
                transform.Translate(Vector3.left * velocidade);
            }
            else if (joystickRight.Horizontal != 0)
            {
                transform.Translate(Vector3.right * velocidade);
            }
            else
            {
                transform.Translate(Vector3.right * 0);
                transform.Translate(Vector3.left * 0);
            }
        }
    }

   
}
