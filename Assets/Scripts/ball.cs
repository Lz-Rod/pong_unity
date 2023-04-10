using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float var_speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float var_speedX = Random.Range(0,2) == 0 ? -1 : 1;
        float var_speedY = Random.Range(0,2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(var_speed * var_speedX, var_speed * var_speedY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
