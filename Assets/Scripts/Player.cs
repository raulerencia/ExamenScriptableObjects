using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    public Inventory inventory;
    private Rigidbody rb;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(1,0,0) * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
    }

    
}
