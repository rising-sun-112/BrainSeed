using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Level : MonoBehaviour
{
    public GameObject lvstate = null;
    public GameObject attackstate = null;
    public GameObject speedstate = null;
    public GameObject defensestate = null;
    int lv;
    int attack;
    int speed;
    int defense;

    // Start is called before the first frame update
    void Start()
    {
        lv = PlayerPrefs.GetInt ("LV", 1);
        attack = PlayerPrefs.GetInt ("ATTACK", 1);
        speed = PlayerPrefs.GetInt ("SPEED", 1);
        defense = PlayerPrefs.GetInt ("DEFENSE", 1);

        int new_lv = lv + 1;// レベルアップしたらlvに1足してnew_lvとして持っておく
        PlayerPrefs.SetInt ("LV", new_lv);
        PlayerPrefs.Save ();
    }

    // Update is called once per frame
    void Update()
    {
        Text nowlv = lvstate.GetComponent<Text> ();
        nowlv.text = "LV" + lv;
        Text nowattack = attackstate.GetComponent<Text> ();
        nowattack.text = "\nATTACK" + attack;
        Text nowspeed = speedstate.GetComponent<Text> ();
        nowspeed.text = "SPEED" + speed;
        Text nowdefense = defensestate.GetComponent<Text> ();
        nowdefense.text = "DEFENSE" + defense;

    }
}
