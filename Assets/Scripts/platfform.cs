using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platfform : MonoBehaviour
{
    public float var_speed = 5f;
    public bool var_isRight;
    // Update is called once per frame
    void Update()
    {
        //se a plataforma controlada for a direita o input vertical1 moverá, caso contrario o vertical2 movera a plataforma esquerda
        if(var_isRight)
        {
            transform.Translate(0f, Input.GetAxis("Vertical1") * var_speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * var_speed * Time.deltaTime, 0f);
        }
    }
}
