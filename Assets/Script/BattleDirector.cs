using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Seed;
using UnityEngine.UI;


public class BattleDirector : MonoBehaviour
{
    public Slider playerslider;
    public Slider enemyslider;
    int turn = 0;
    bool isBattleEnd;
    Player player;
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        playerslider.value = 1;
        enemyslider.value = 1;
        player = new Player();
        enemy = new Enemy(1);
        isBattleEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 仮でマウスボタンをクリックしたら1ターン経過するようにする
        // if (Input.GetMouseButtonDown(0) {
        //     CalcTurn();
        // }
        
    }

    // ターン経過処理
    public void CalcTurn(int skill)
    {
        if (isBattleEnd)
        {
            return;
        }
        
        turn++;
        // 先行は自キャラから敵にダメージを与える
        enemy.CalcDamage(player.CalcAttack(skill));
        enemyslider.value = enemy.gethpratio();

        if (enemy.isDead())
        {
            Debug.Log("プレイヤーの勝利");
            isBattleEnd = true;
        }

        // 後攻は敵キャラから自キャラにダメージを与える
        player.CalcDamage(enemy.CalcAttack());
        playerslider.value = player.gethpratio();
                
        if (player.isDead())
        {
            Debug.Log("エネミーの勝利");
            isBattleEnd = true;
        }
    }
}
