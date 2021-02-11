using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFriendBattleReadyButton : MonoBehaviour
{
         public void OnClick() {
    Debug.Log("Button click!");
    SceneManager.LoadScene("FriendBattleReady");
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
