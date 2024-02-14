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
        //mo�na pro�ciej: Vector3.right


        //zczytaj klawiatur� w osi poziomej:
        //float horizontalInput = Input.GetAxis("Horizontal");
        //wylicz przesuni�cie w osi x
        

        //zczytaj z klawiatury o� y
        float verticalInput = Input.GetAxis("Vertical");
        //wylicz przesuni�cie w osi y i dodaj do istniej�cego przesuni�cia w osi x
        movement += Vector3.forward * verticalInput;

        //normalizujemy wektor
        movement = movement.normalized;
        //poprawka na czas od ostatniej klatki
        movement *= Time.deltaTime;
        //pomn� przez pr�dko�� ruchu
        movement *= moveSpeed;
        
       //przesu� gracza w osi x
        transform.position += movement;
        
    }
}
