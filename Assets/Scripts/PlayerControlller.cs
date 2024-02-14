using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlller : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        //mo¿na proœciej: Vector3.right


        //zczytaj klawiaturê w osi poziomej:
        //float horizontalInput = Input.GetAxis("Horizontal");
        //wylicz przesuniêcie w osi x
        

        //zczytaj z klawiatury oœ y
        float verticalInput = Input.GetAxis("Vertical");
        //wylicz przesuniêcie w osi y i dodaj do istniej¹cego przesuniêcia w osi x
        movement += Vector3.forward * verticalInput;

        //normalizujemy wektor
        movement = movement.normalized;
        //poprawka na czas od ostatniej klatki
        movement *= Time.deltaTime;
        //pomnó¿ przez prêdkoœæ ruchu
        movement *= moveSpeed;
        
       //przesuñ gracza w osi x
        transform.position += movement;
        
    }
}
