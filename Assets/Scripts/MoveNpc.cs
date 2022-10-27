using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNpc : MonoBehaviour
{
    Rigidbody _rb = null;
    public float speed = 400;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveH, 0, moveV);
        _rb.AddForce(move * speed * Time.deltaTime);
    }
}
