using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip coinSound;

    public float movementSpeed = 5;
    Rigidbody2D rb;
    float xMove;
    float yMove;
    public TextMeshPro playerScoreText;
    int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScoreText.text = playerScore.ToString();

        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
        //transform.Translate(Time.deltaTime * movementSpeed * xMove,0,0);

    }

    public void IncrementScore(int scoreChange)
    {
        playerScore += scoreChange;


    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(Time.deltaTime * movementSpeed * xMove, Time.deltaTime * movementSpeed * yMove);
        rb.velocity = new Vector2(xMove, yMove) * (Time.deltaTime * movementSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            int value = collision.gameObject.GetComponent<CoinScript>().coinValue;
            IncrementScore(value);

            audioSource.PlayOneShot(coinSound);

            Destroy(collision.gameObject);
        }

    }
}
