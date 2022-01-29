using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain_Vel_1 : MonoBehaviour
{
    float speedRain = 10.00f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveRain(Vector3.down * 1f);
    }
    void MoveRain(Vector3 direction)
    {
        transform.Translate(speedRain * Time.deltaTime * direction);
    }
}
