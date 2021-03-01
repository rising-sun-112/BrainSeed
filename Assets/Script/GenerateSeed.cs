using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSeed : MonoBehaviour
{
    // Start is called before the first frame update
    
    
        public GameObject seedPrefab;
    // Start is called before the first frame update
    void Start()
    {
       int level = PlayerPrefs.GetInt("LV", 1);
       var instant = Instantiate(seedPrefab);
       float scale = 1.0f;
       level = 13;
       if (level > 10)
       {
           scale = 0.5f;
           instant.transform.localScale = new Vector3(scale, scale, scale);
       }
       for (int i = 0; i < level; ++i) 
       {
           float x = PlayerPrefs.GetFloat($"level_{i}_x", 0.0f);
           float y = PlayerPrefs.GetFloat($"level_{i}_y", 0.0f);
           float z = PlayerPrefs.GetFloat($"level_{i}_z", 0.0f);

           int r = PlayerPrefs.GetInt($"level_{i}_r", -1);
           int g = PlayerPrefs.GetInt($"level_{i}_g", -1);
           int b = PlayerPrefs.GetInt($"level_{i}_b", -1);

           int color = PlayerPrefs.GetInt($"level_{i}_color", -1);

           if (color == -1) {
               color = Random.Range(0, 100);
               
               PlayerPrefs.SetInt($"level_{i}_color", color);
           }


           if (x == 0.0f) {
               x = Random.Range(-1.0f, 1.0f);
               y = Random.Range(-1.0f, 1.0f);
               z = Random.Range(-1.0f, 1.0f);

               PlayerPrefs.SetFloat($"level_{i}_x", x);
               PlayerPrefs.SetFloat($"level_{i}_y", y);
               PlayerPrefs.SetFloat($"level_{i}_z", z);
           }

           var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
           go.transform.localScale = new Vector3(scale, scale, scale);
           go.transform.parent = instant.transform;           

           Debug.Log(x);
           go.transform.position =  new Vector3(x, y, z);

           var colorCode = Color.white;
           if (color == 0)
           {
               colorCode = Color.red;
           }
           else if (color == 1)
           {
               colorCode = Color.blue;
           }
           else if (color == 2)
           {
               colorCode = Color.green;
           }
           else if (color == 3)
           {
               colorCode = Color.cyan;
           }
           else if (color == 4)
           {
               colorCode = Color.magenta;
           }
           else if (color == 5)
           {
               colorCode = Color.black;
           }
           else if (color == 6)
           {
               colorCode = Color.gray;
           }
           else if (color == 7)
           {
               colorCode = Color.yellow;
           }
           else if (color == 8)
           {
               colorCode = new Color(0,255,0,1);
           }
           else if (color == 9)
           {
               colorCode = new Color(123,104,238,1);
           }
           else if (color == 10)
           {
               colorCode = new Color(210,105,30,1);
           }
           
           go.GetComponent<Renderer>().material.color = colorCode;
       }
       PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
