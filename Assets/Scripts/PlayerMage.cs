using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMage : Fighter
{
    [Header("UI")]

    public PlayerSkillPanel skillPanel;

    void Awake(){
        this.stats = new Stats(100,10,10);
    }

    public override void InitTurn(){
        this.skillPanel.Show();

        for(int i=0; i<this.skills.Length; i++){
            this.skillPanel.ConfigureButtons(i,this.skills[i].skillName);
        }
    }

    public void ExecuteSkill(int index){
        this.skillPanel.Hide();
        Skill skill = this.skills[index];

        skill.SetEmitterAndReceiver(this,this.combatManager.GetOpposingFighter());

        this.combatManager.OnFighterSkill(skill);
    }
}
