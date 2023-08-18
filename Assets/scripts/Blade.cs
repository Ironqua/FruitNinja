using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public Vector3 direction { get; private set; }
    public float bladeforce;

    bool slicing = false;
    Rigidbody2D rb;
     Camera cam;
    private TrailRenderer bladetrail;
    private Collider2D sliceCollider;
    //public GameObject bladetrailprefab;
    GameObject currentbladetrail;
   
    public float minSliceVelocity = 0.01f;
    private void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        sliceCollider = GetComponent<Collider2D>();

        bladetrail = GetComponentInChildren<TrailRenderer>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startslice();
        }
        else if(Input.GetMouseButtonUp(0)) 
        {
            stopslice();
        }
        if (slicing)
        {
            updateslice();
        }
        //else if(slicing)
        //{
        //    contuineslice();
        //}
    }

    void startslice()
    {
        Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0f;
        transform.position = position;

        slicing = true;
        sliceCollider.enabled = true;
        //currentbladetrail= Instantiate(bladetrailprefab,transform);
        bladetrail.enabled = true;
        bladetrail.Clear();
     
    }

    //void contuineslice()
    //{
     
    //}

    void stopslice()
    {
        slicing = false;
        sliceCollider.enabled = false;
        bladetrail.enabled=false;
       
    }
    void updateslice()
    {
        //rb.position=cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0f;
        transform.position = position;


        ////float velocity = direction.magnitude / Time.deltaTime;
        ////sliceCollider.enabled = velocity > minSliceVelocity;

        ////transform.position = position;

        //currentbladetrail.transform.SetParent(null);
        //Destroy(currentbladetrail,2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bomb"))
        {
            Debug.Log("bom;");
        }
    }
}
