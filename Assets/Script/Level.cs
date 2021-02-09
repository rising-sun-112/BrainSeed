using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
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
        
    }
}
