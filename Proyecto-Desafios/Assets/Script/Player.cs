using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int lifePlayer = 3;
    [SerializeField]string namePlayer = "Mr.Red";
    [SerializeField]float speedPlayer = 10.00f;
    // Start is called before the first frame update
    void Start()
    {
        Inicio();
    }
    // Update is called once per frame
    void Update()
    {
        MovePlayer(Vector3.forward * 2f);
    }
    void Inicio()
    {
        transform.position = new Vector3(3.641f, 1.54f,-4.06f);
    }
    public void MovePlayer( Vector3 direction){
        transform.Translate(speedPlayer * Time.deltaTime * direction);
    }
    public void DamagePlayer(){
        lifePlayer--;
        if(lifePlayer <= 0){
            Destroy(gameObject);
        }
    }
    public void AddLifePlayer(){
        lifePlayer++;
    }
}
