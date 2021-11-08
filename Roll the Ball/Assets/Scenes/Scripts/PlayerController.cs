using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{    
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 10.0f;

    private int score;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        setScoreText();
    }

    // Player movement
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(horizontalInput, 0.0f, verticalInput) * speed);
    }

    // collect coins
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            score++;
            setScoreText();
        }
        
    }

    //add to score when a coin is collected
    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
