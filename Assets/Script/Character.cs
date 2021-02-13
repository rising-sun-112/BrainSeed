using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Seed
{
    public class Character
    {
        protected int _level = 1;
        protected int _hp = 10;
        protected int _attack = 1;
        protected int _defense = 1;

        public int CalcAttack(int skill = 0)
        {
            int attackPower = _attack * Random.Range(0, 3);
            if (skill > 0)
            {
                // スキルが0以上の場合はここでattackPowerに対して効果をかける
                // attackPower *= buff
            }

            return attackPower;
        }

        public void CalcDamage(int damage)
        {
            _hp -= damage;
            if (_hp < 0)
            {
                _hp = 0;
            }
            Debug.Log($"{this.GetType().Name}は{damage}のダメージを受けました。残りHPは{_hp}");
        }

        public bool isDead()
        {
            if (_hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Player : Character
    {
        public Player()
        {
            _level = PlayerPrefs.GetInt("LV", 1);
            _attack = PlayerPrefs.GetInt("ATTACK", 1);
            _hp = PlayerPrefs.GetInt("HP", 10);
            _defense = PlayerPrefs.GetInt("DEFENSE", 1);
        }
    }

    public class Enemy : Character
    {
        public Enemy(int level)
        {
            _level = level;
            _attack = level * 2;
            _hp = level * 20;
            _defense = level * 2;
        }
    }
}