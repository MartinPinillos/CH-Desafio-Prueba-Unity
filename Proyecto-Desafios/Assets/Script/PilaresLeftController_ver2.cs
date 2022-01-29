using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaresLeftController_ver2 : MonoBehaviour
{
    float speedPilar = 1.00f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePilar(Vector3.right * 0.7f);
    }
    void MovePilar(Vector3 direction)
    {
        transform.Translate(speedPilar * Time.deltaTime * direction);
    }
}
