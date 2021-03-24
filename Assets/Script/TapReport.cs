using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapReport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SendLineMessage() {
string url = "http://line.me/R/msg/text/?" + WWW.EscapeURL("https://brainseed-3948f.web.app");
Application.OpenURL(url);
    }
}
