using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float horizontalInput;
    private float verticalInput;
    public float speed = 5;
    public Rigidbody rb;
    

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical"); // -1 ile 1 arasýnda deðer döndürür basýp basmadýðýný anlamak için
        rb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime, ForceMode.Impulse);

        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * horizontalInput * speed * Time.deltaTime, ForceMode.Impulse);
            
    }
}
