using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public float Speed = 5;
    public bool isRight;
    void Update()
    {
        if (isRight)
        {
            transform.Translate(0, Input.GetAxis("Vertical") * Speed * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, Input.GetAxis("Vertical2") * Speed * Time.deltaTime, 0);
        }
    }
}
