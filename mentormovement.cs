using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Playercontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 0f;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;
    public GameObject door;
    public GameObject winUI;
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();
    }
    void OnMove(InputValue value)
    {
        Vector2 movementvector = value.Get<Vector2>();
        // Move the player character based on the input
        movementX = movementvector.x;
        movementY = movementvector.y;

    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the horizontal and vertical input axes

        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coll"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
          
            SetCountText();
            if (count >= 5)
            {
                door.SetActive(true);
            }
        }

        else if (other.gameObject.CompareTag("next"))
        {
            SceneManager.LoadScene("sceneB");
        }
        
        else if (other.gameObject.CompareTag("endGame"))
        {

            winUI.SetActive(true);
        }

    }


}
