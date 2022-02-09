using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : Fighter
{
    void Awake(){
        this.stats = new Stats(80,5,5);
    }

    void resetHealth(){
        this.stats.health = 80;
    }

    public override void InitTurn(){
        StartCoroutine(this.IA());
    }

    IEnumerator IA(){
        yield return new WaitForSeconds(1f);

        Skill skill = this.skills[0];

        skill.SetEmitterAndReceiver(this, this.combatManager.GetOpposingFighter());

        this.combatManager.OnFighterSkill(skill);
    }
    
}
