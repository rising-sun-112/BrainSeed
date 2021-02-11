using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOAIBattleReadyButton : MonoBehaviour
{
         public void OnClick() {
    Debug.Log("Button click!");
    SceneManager.LoadScene("AI");
  }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
