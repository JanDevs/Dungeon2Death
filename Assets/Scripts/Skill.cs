using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    [Header("Base Skill")]
    public string skillName;
    public float animationDuration;

    public bool selfInflicted;

    public GameObject effectPrfb;

    protected Fighter emitter;
    protected Fighter receiver;

    public int limit;

    private void Animate(){
        var go = Instantiate(this.effectPrfb, this.receiver.transform.position, Quaternion.identity);
        Destroy(go, this.animationDuration);
    }

    public void Run(){
        if(limit>0){
            if(this.selfInflicted){
                this.receiver = this.emitter;
            }
            this.Animate();
            this.OnRun();
            limit--;
        }else{
            LogPanel.Write("Ya no tienes mas de eso.");
        }
    }

    public void SetEmitterAndReceiver(Fighter _emitter, Fighter _receiver){
        this.emitter = _emitter;
        this.receiver = _receiver;
    }
    protected abstract void OnRun();
}
