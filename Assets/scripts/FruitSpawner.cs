using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{

 public     Collider spawnArea;
    public GameObject[] fruitprefab;
    public float minDelay; // spawn aras�ndaki minimum gecikme 
    public float maxDelay; // spawn s�ras�nda max gecikme

    public GameObject bombprefab;
    public float bombcooldown = 0.05f;

    //public float minangle;
    //public float maxangle;

   
    void Awake()
    {
     spawnArea=GetComponent<Collider>();

        StartCoroutine(Spawn());
    }

    
    

    private IEnumerator Spawn() 
    {

        

        while (enabled)
        {
            //yield return new WaitForSeconds(2f);

          

            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            GameObject fruit = fruitprefab[Random.Range(0,fruitprefab.Length)]; // listteki prefablar� random olarak list uzunlu�unda fruite atama

            if (Random.value < bombcooldown)
            {
                fruit = bombprefab;
            }

            Vector3 position = new Vector3();
           


            position.x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
            position.y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
            position.z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z); // collider�n kapsad��� max min  kordinat de�erleri anlam�na gelir 
            // klasik vector3 de ayn� mant�� sa�lard� bundan dolay� coiilder� da �ekmemize gerek kalmazd� denenebilir ama bunun kadar g,zel �al��mayabilir 
          

            //Quaternion rot=Quaternion.Euler(0f,0f,Random.Range(minangle,maxangle));

            Instantiate(fruit, position, Quaternion.Euler(0f,0f,Random.Range(0f,90f)));

            //if (fruit.transform.position.y < -15f)
            //{
            //    Destroy(fruit);
            //}
            // fruitin kuvvetini farkl� bir scriptte yapt�k ayn� �ekilde destro i�inide 
                


            
        }

    }
}
