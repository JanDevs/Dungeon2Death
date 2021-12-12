using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using charact;

namespace Combat
{
 public class CombatCtrl : MonoBehaviour
{
  public int EnemyN=2, PlayersN=1;
  public int EnemySelect, PlayerSelect;
  public GameObject Enemies, Player;
  bool turn = true;
  public character character;

  private void Start()
  {
    character stats = Player.transform.GetChild(PlayerSelect).GetComponent<character>();
    stats.Select(true);
  }

  private void Update()
  {
      if(EnemyN>=0)
      {
        Enemies.transform.GetChild(EnemySelect).GetComponent<character>().Select(false);
        if(Input.GetKeyDown(KeyCode.W))
          EnemySelect--;
        if(Input.GetKeyDown(KeyCode.S))
          EnemySelect++;
        EnemySelect = Mathf.Clamp(EnemySelect,0,EnemyN);
        Enemies.transform.GetChild(EnemySelect).GetComponent<character>().Select(true);
      }
  }

  public void Attack()
  {
    if(turn && PlayersN>=0)
    {
      character ch = Player.transform.GetChild(PlayerSelect).GetComponent<character>();
      ch.Attack();

      if(PlayerSelect==PlayersN)
      {
        PlayerSelect = 0;
        turn = false;
        StartCoroutine(AttackE());
      }else{
        PlayerSelect++;
      }

      ch.Select(false);
      ch = Player.transform.GetChild(PlayerSelect).GetComponent<character>();
      ch.Select(true);
    }

    IEnumerator AttackE()
    {
      if(EnemyN >=0)
      {
        yield return new WaitForSecondsRealtime(1f);
        for(int i=0; i <= EnemyN; i++)
        {
          Enemies.transform.GetChild(i).GetComponent<character>().Attack();
          yield return new WaitForSecondsRealtime(1f);
        }
        turn=true;
      }
    }
  }
}
   
}
