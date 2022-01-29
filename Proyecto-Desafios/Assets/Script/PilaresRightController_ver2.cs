using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaresRightController_ver2 : MonoBehaviour
{
    float speedPilar = 1.00f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        MovePilar(Vector3.left * 0.7f);
        //transform.position += new Vector3(-0.7f,0f,0f) * Time.deltaTime * speedPilar;
    }
    void MovePilar(Vector3 direction)
    {
        transform.Translate(speedPilar * Time.deltaTime * direction);
    }
}
