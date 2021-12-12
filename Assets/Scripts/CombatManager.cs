using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum CombatStatus{
    WAITING_FOR_FIGHTER,
    FIGHTER_ACTION,
    CHECK_FOR_VICTORY,
    NEXT_TURN
}


public class CombatManager : MonoBehaviour
{
    public Fighter[] fighters;
    private int fighterIndex;

    private bool isCombatActive;
    private CombatStatus combatStatus;
    private Skill currentFighterSkill;
    
    public Canvas canvas1;

    void Start(){
        LogPanel.Write("La batalla ha iniciado.");
        
        foreach (var fgtr in this.fighters)
        {
            fgtr.combatManager=this;
        }

        this.combatStatus = CombatStatus.NEXT_TURN;
        
        this.fighterIndex=-1;
        this.isCombatActive = true;
        StartCoroutine(this.CombatLoop());
    }

    IEnumerator CombatLoop(){
        while(this.isCombatActive){
            switch (this.combatStatus)
            {
                case CombatStatus.WAITING_FOR_FIGHTER:
                    yield return null;
                    break;
                
                case CombatStatus.FIGHTER_ACTION:
                    LogPanel.Write($"{this.fighters[this.fighterIndex].idName} usa {currentFighterSkill.skillName}.");
                    yield return null;
                    
                    currentFighterSkill.Run();

                    yield return new WaitForSeconds(currentFighterSkill.animationDuration);
                    this.combatStatus=CombatStatus.CHECK_FOR_VICTORY;

                    currentFighterSkill=null;
                    break; 
                
                case CombatStatus.CHECK_FOR_VICTORY:
                    foreach (var fgtr in this.fighters)
                    {
                        if(fgtr.isAlive==false){
                            this.isCombatActive=false;
                            LogPanel.Write("¡Victoria!");
                            yield return new WaitForSeconds(2);
                            
                            SceneManager.UnloadSceneAsync("Combate");

                        }else{
                            this.combatStatus=CombatStatus.NEXT_TURN;
                        }
                    }
                    yield return null;
                    break;

                case CombatStatus.NEXT_TURN: 
                    yield return new WaitForSeconds(1f);
                    this.fighterIndex = (this.fighterIndex + 1) % this.fighters.Length;
                    var currentTurn = this.fighters[this.fighterIndex];
                    
                    LogPanel.Write($"{currentTurn.idName} tiene el turno.");
                    currentTurn.InitTurn();

                    this.combatStatus = CombatStatus.WAITING_FOR_FIGHTER;

                    break;
            }
        }
    }

    public Fighter GetOpposingFighter(){
        if(this.fighterIndex==0){
            return this.fighters[1];
        }else{
            return this.fighters[0];
        }
    }

    public void OnFighterSkill(Skill skill){
        this.currentFighterSkill = skill;
        this.combatStatus = CombatStatus.FIGHTER_ACTION;
    }


}
