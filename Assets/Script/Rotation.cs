using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Vector3 pos;         // クリック時のマウス位置
    Quaternion rotation; // クリックしたときのターゲットの角度
    


    Vector3 vecA;        // ターゲットの中心からposへのベクトル
    Vector3 vecB;        // ターゲットの中心から現マウス位置へのベクトル

    float angle;         // vecAとvecBが成す角度
    Vector3 AxB;         // vecAとvecBの外積

    bool Drag;           //ドラッグ中のフラグ


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // マウスのクリック状態からメソッドを選択
        if (Drag)
        {
            Rotate();
        }
        else
        {
            SetPos();
        }
    }
     //マウスをクリックした時の処理
    void SetPos()
    {
        //クリック時のマウスの初期位置とターゲットの現角度を取得
        if (Input.GetMouseButtonDown(0))
        {
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウス位置をワールド座標で取得
            rotation = this.transform.rotation;                        // ターゲットの現角度を取得
            Drag = true;                                               // クリックフラグをONにする
        }
    }

    //ドラッグ中かを判断して処理を行う
    public void Rotate()
    {
        //ドラッグが解除されたらフラグをOFFにしてReturn
        if (Input.GetMouseButtonUp(0))
        {
            Drag = false;
            return;
        }

        //マウス初期位置のベクトルを求める
        vecA = pos - (Vector3)this.transform.position;

        //現マウス位置のベクトルを求める
        vecB = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;

        // Vector2にしているのはz座標が悪さをしないようにするため

        //マウスの初期位置と現マウス位置から角度と外積を求める
        angle = Vector3.Angle(vecA, vecB);  //角度を計算
        AxB = Vector3.Cross(vecA, vecB);    //外積を計算

        // 外積の z 成分の正負で回転方向を決める
        if (AxB.z > 0)
        {
            this.transform.localRotation = rotation * Quaternion.Euler(0, 0, angle); // 初期値との掛け算で相対的に回転させる
        }
        else
        {
            this.transform.localRotation = rotation * Quaternion.Euler(0, 0, -angle); // 初期値との掛け算で相対的に回転させる
        }
        Debug.Log (pos);
        Debug.Log (rotation);
        Debug.Log (Drag);
        Debug.Log (vecA);
        Debug.Log ("mousePosition");
    }
}
