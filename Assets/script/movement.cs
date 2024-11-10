using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rigig;    
    public float vertical;
    public float horizontal;
    // Start is called before the first frame update
    void Awake()
    {
     rigig = GetComponent<Rigidbody2D>();   
    }
    private void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rigig.velocity = new Vector2(horizontal, vertical);
    }
}
