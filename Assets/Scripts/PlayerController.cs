using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10.0f;
    public GameObject groundboiSpot;
    public GameObject projectilePrefab;
    // public Rigidbody pumpkin;
    public float jumpForce = 200f;
    public float RotateSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        Debug.Log(speed);

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(90f, 0f, 0f, Space.pumpkin);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            pumpkin.AddForce(Vector3.up * jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            speed = 20.0f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10.0f;
        }

    }

    //collectibles
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }

    }
}