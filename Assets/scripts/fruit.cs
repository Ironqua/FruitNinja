using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class fruit : MonoBehaviour

    
{
    public GameObject juicepartical;
    Rigidbody2D rb;
    public float speed;

    public GameObject fruitsliced;
   

  
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();  
        rb.AddForce(Vector3.up*speed,ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -15f)
        {
            Destroy(this.gameObject);
        }
    }

    // brackeys dakka 40 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
            //gameObject.SetActive(false);
            //Vector3 spawnpos=transform.position;
            Vector3 direction = (collision.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);
            Instantiate(juicepartical,transform.position,Quaternion.identity);
            GameObject slicedFruit = Instantiate(fruitsliced, transform.position, rotation);

            FindAnyObjectByType<gamemanager>().updatescore(50);

            Destroy(slicedFruit, 3f);
            Destroy(gameObject);
            //Debug.Log("hit;");
            
       }

    }
}
