using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Seed;
using System.Linq;


public class Skillirector : MonoBehaviour
{
    
    public Text skill1;
     public Text skill2;
      public Text skill3;
       public Text skill4;
    // Start is called before the first frame update
    void Start()
    {
        var player = new Player();
        var skillmasterasset = Resources.Load("SkillMaster") as SkillMasterAsset;

        var skillMaster = skillmasterasset.SkillMasterList.Where(skillMaster => skillMaster.id == player._skillId1).FirstOrDefault();
        skill1.text = skillMaster.SkillName;
        player._skillId1 = 2;
        player.skillsave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
