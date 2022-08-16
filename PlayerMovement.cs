using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode flyKey;

    public float force;
    public Rigidbody2D rb;

    public GameObject Restart;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(flyKey))
        {
            rb.velocity = Vector2.up * force;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Entity")
        {
            Time.timeScale = 0;
            Restart.SetActive(true);
        }
    }
}
