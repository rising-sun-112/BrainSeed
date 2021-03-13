using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Firestore;
using Firebase.Extensions;


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
        FirebaseFirestore db = FirebaseFirestore.DefaultInstance;
        CollectionReference usersRef = db.Collection("users");
        usersRef.GetSnapshotAsync().ContinueWithOnMainThread(task =>
        {
            QuerySnapshot snapshot = task.Result;
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Debug.Log("test");
                if (document.Id != "j10aXz4huKMUDpt86i1n")
                {
                    continue;
                }
                Debug.Log("test1");
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                var hoge = documentDictionary["attack"];
                Debug.Log(hoge);
                attack = int.Parse(hoge.ToString());
                Debug.Log(hoge);
                lv = int.Parse(documentDictionary["level"].ToString());
                Debug.Log("test1");
                speed = int.Parse(documentDictionary["speed"].ToString());
                defense = int.Parse(documentDictionary["defense"].ToString());
                Debug.Log("test2");
                PlayerPrefs.SetInt("LV", lv);
                PlayerPrefs.SetInt("ATTACK", attack);
                PlayerPrefs.SetInt("SPEED", speed);
                PlayerPrefs.SetInt("DEFENSE", defense);
                PlayerPrefs.Save();
            }
        });
        lv = PlayerPrefs.GetInt("LV", 1);
        attack = PlayerPrefs.GetInt("ATTACK", 1);
        speed = PlayerPrefs.GetInt("SPEED", 1);
        defense = PlayerPrefs.GetInt("DEFENSE", 1);
        PlayerPrefs.Save();
        
    }

    // Update is called once per frame
    void Update()
    {
        Text nowlv = lvstate.GetComponent<Text> ();
        nowlv.text = "LV" + lv;
        Text nowattack = attackstate.GetComponent<Text> ();
        nowattack.text = "ATTACK" + attack;
        Text nowspeed = speedstate.GetComponent<Text> ();
        nowspeed.text = "SPEED" + speed;
        Text nowdefense = defensestate.GetComponent<Text> ();
        nowdefense.text = "DEFENSE" + defense;

    }
}
