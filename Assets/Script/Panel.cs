using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class Panel : MonoBehaviour
{
    [SerializeField] GameObject Senntaku;
    [SerializeField] GameObject Battle;
    
 
 
    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        // BackToMenu();
    }
 
 
    //MenuPanelでXR-HubButtonが押されたときの処理
    //XR-HubPanelをアクティブにする
    public void SelectSenntakuDescription()
    {
        Senntaku.SetActive(false);
        Battle.SetActive(true);
    }
 
 
    //MenuPanelでUnityButtonが押されたときの処理
    //UnityPanelをアクティブにする
    public void SelectBattleDescription()
    {
        Battle.SetActive(false);
        Senntaku.SetActive(true);
    }
 
 
    //2つのDescriptionPanelでBackButtonが押されたときの処理
    //MenuPanelをアクティブにする
    // public void BackToMenu()
    // {
    //     menuPanel.SetActive(true);
    //     xrHubPanel.SetActive(false);
    //     unityPanel.SetActive(false);
    // }
}
