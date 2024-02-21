using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CharacterController controller;
    public float velocidadMov;
    public float velocidadGiro;
    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimiento = Input.GetAxis("Vertical");
        float rotacion = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3( 0, 0, movimiento * velocidadMov);
        Vector3 rotation = new Vector3 (0, rotacion * velocidadGiro, 0);

        controller.transform.Translate (movement);
        controller.transform.Rotate( rotation, velocidadGiro);
        
    }
}
