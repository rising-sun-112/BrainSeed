using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gizmo : MonoBehaviour
{   
    GameObject seed;

         public void OnClick() {
    int count =0;
        if (count == 0)
        {
            this.seed.transform.rotation = Quaternion.Euler(0,0,0);
            count = count + 1;
        }
        else if (count == 1)
        {
            this.seed.transform.rotation = Quaternion.Euler(60,60,60);
            count = count + 1;
        }
    
  }

    // Start is called before the first frame update
    void Start()
    {
        this.seed = GameObject.Find("Seed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
