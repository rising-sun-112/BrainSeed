using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ListViewController : MonoBehaviour
{
    public RectTransform content_;
    public GameObject item_prefab_;
    public string[] itemList_;
    private float itemHight_;
    private SkillMasterAsset skillmasterasset;
    // Start is called before the first frame update
    void Start()
    {
        GameObject item = GameObject.Instantiate(item_prefab_) as GameObject;
    RectTransform rect = item.transform as RectTransform;
    itemHight_ = rect.rect.height;
    GameObject.Destroy(item);
    skillmasterasset = Resources.Load("SkillMaster") as SkillMasterAsset;


    UpdateListView();
    }

    private void UpdateListView() {
    // item数に合わせてContentの高さを変更する.
    int setting_count = skillmasterasset.SkillMasterList.Count;
    float newHeight = setting_count * itemHight_;
    content_.sizeDelta = new Vector2(content_.sizeDelta.x, newHeight); // 高さを変更する.

    // Contentの子要素にListViewItemを追加していく.
    // mdemo 今はitemListという文字のリストをforeachで回しているがスキルマスタのlistをここで使用してskillのリストを表示する
    foreach (var skillMaster in skillmasterasset.SkillMasterList) {
        GameObject item = GameObject.Instantiate(item_prefab_) as GameObject; // ListViewItem のインスタンス作成.
        Text itemText = item.GetComponentInChildren<Text>(); // Textコンポーネントを取得.
        itemText.text = skillMaster.SkillName;

        var button = item.GetComponentInChildren<Button>();
        button.onClick.AddListener(() => {
            //character.skillId1 = skillList.id;
            //Debug.Log(itemStr);
        });

        RectTransform itemTransform = (RectTransform)item.transform;
        itemTransform.SetParent( content_, false ); // 作成したItemをContentの子要素に設定.
    }
}
}
