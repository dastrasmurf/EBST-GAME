using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    private float speed = 30;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(GetPosition() * speed * Time.deltaTime, ForceMode.Force);
    }
    Vector3 GetPosition()
    {
        return player.transform.position - gameObject.transform.position;
    }
       


}
