using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
   
    //public Image fade;
    public Text scoreText;
    private int score;
    public void updatescore(int s)
    {
        score += s;
        scoreText.text=score.ToString();

    }

   
    //public void Explode()
    //{
     

    //    StartCoroutine(explode());
    //}



    //private IEnumerator explode()
    //{
    //    float elapsed = 0f;
    //float duration = 0.5f;
    //    while (elapsed < duration);
    //    {
    //        float t = Mathf.Clamp01(elapsed / duration);
    //        fade.color=Color.Lerp(Color.white, Color.clear, t);
    //        Time.timeScale = 1f - t;
    //        elapsed += Time.unscaledDeltaTime;
    //        yield return null;
    //    }
    //    yield return new WaitForSeconds(1f);
    //}
}
