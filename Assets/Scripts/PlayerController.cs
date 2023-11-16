using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;
    private GameObject[] tags;

    public float speed;
    public TextMeshProUGUI scoreText;
    public GameObject winTextObject;
    public CoinManage CoinManage;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winTextObject.SetActive(false);
        
    }

    private void Update()
    {
        SetCountText();
    }
    private void OnMove(InputValue movementValue)
    {

        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void SetCountText()
    {
        scoreText.text = "Score: " + (count*25).ToString("0000");

        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (count == 0)
        {
            
            tags = GameObject.FindGameObjectsWithTag("Coin");

            
            SetCountText();
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count++;

            if (count == tags.Length)
            {

                winTextObject.SetActive(true);
                Time.timeScale = 0f;

            }

        }
    }
}
