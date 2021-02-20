using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    private BattleDirector director;
    public void skill1Click()
    {
        director.CalcTurn(1);

    }
    // public void skill2Click();
    // public void skill3Click();
    // public void skill4Click();

    // Start is called before the first frame update
    void Start()
    {
        director = GameObject.Find("BattleDirector").GetComponent<BattleDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
