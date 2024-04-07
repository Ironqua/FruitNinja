using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public GameObject explode;
   
    Rigidbody2D rb;
    public float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector3.up * speed, ForceMode2D.Impulse);
    }

 
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("bom;");

            Instantiate(explode, transform.position, Quaternion.identity);

            //Time.timeScale = 0f;
            
            //FindObjectOfType<gamemanager>().Explode();
            Invoke("PauseGame", 1f);

        }
    }
    private void PauseGame()
    {
        SceneManager.LoadScene("oyun sonu");

        Time.timeScale = 0f; 
    }
}
