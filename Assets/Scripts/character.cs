using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Combat;

namespace charact{



public class character : MonoBehaviour
{
    GameObject targets;
    CombatCtrl combatctrl;
    public GameObject barlife;
    public GameObject select;
    public SpriteRenderer sr;

    float ScaleI;
    int maxlife;
    public int life;
    public int attack;
    int target;

    public bool type;

    private void Start()
    {
        ScaleI = barlife.transform.localScale.x;
        maxlife=life;
        combatctrl = GameObject.Find("CombatCtrl").GetComponent<CombatCtrl>();
        if(type)
            targets = GameObject.Find("Enemies");
        else 
            targets = GameObject.Find("Player");
    }

    public void Attack()
    {
        StartCoroutine(AnimAttack());
        if(type) target = combatctrl.EnemySelect;
        else target = combatctrl.PlayerSelect;
        if(combatctrl.EnemyN >=0 && combatctrl.PlayersN>=0)
            targets.transform.GetChild(target).GetComponent<character>().Damage(attack);
    }

    public void Damage(int attack)
    {
        life-=attack;
        StartCoroutine(AnimDamage(attack));
        if(life<=0)
        {
            if(type) 
                combatctrl.PlayersN--;
            else
                combatctrl.EnemyN--;
            Destroy(gameObject);
        }    
    }

    public void Select(bool select)
    {
        this.select.SetActive(select);
    }

    IEnumerator AnimAttack()
    {
        float mov=0.3f;
        if(!type)
            mov *= -1;
        transform.position = new Vector3(transform.position.x + mov, transform.position.y, transform.position.z);
        yield return new WaitForSecondsRealtime(0.2f);
        transform.position = new Vector3(transform.position.x - mov, transform.position.y, transform.position.z);
    }

    IEnumerator AnimDamage(float damage)
    {
        barlife.transform.localScale = new Vector3(barlife.transform.localScale.x - (damage/maxlife)*ScaleI, barlife.transform.localScale.y, barlife.transform.localScale.z);
        for(int i=0; i <10; i++)
        {
            sr.enabled = !sr.enabled;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }
}

}
