using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaBola : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 5;
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 movebola = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += movebola * velocidade * Time.deltaTime;
    }
}
