using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Seed;

public class BattleDirector : MonoBehaviour
{
    int turn = 0;
    bool isBattleEnd;
    Player player;
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player();
        enemy = new Enemy(1);
        isBattleEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 仮でマウスボタンをクリックしたら1ターン経過するようにする
        if (Input.GetMouseButtonDown(0)) {
            CalcTurn();
        }
        
    }

    // ターン経過処理
    private void CalcTurn()
    {
        if (isBattleEnd)
        {
            return;
        }
        
        turn++;
        // 先行は自キャラから敵にダメージを与える
        enemy.CalcDamage(player.CalcAttack());

        if (enemy.isDead())
        {
            Debug.Log("プレイヤーの勝利");
            isBattleEnd = true;
        }

        // 後攻は敵キャラから自キャラにダメージを与える
        player.CalcDamage(enemy.CalcAttack());
        
        if (player.isDead())
        {
            Debug.Log("エネミーの勝利");
            isBattleEnd = true;
        }
    }
}
