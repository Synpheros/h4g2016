using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SequenceNodeType {SMS, DIALOG, ACTION};

public class SequenceNode{
    public SequenceNodeType type;
    public bool receive;
    public string text;
    public string talker;
    public int[] talkers;

    public SequenceNode(string action){
        this.type = SequenceNodeType.ACTION;
        this.text = text;
    }

    public SequenceNode(string text, bool receive, string talker = ""){
        this.type = SequenceNodeType.SMS;
        this.text = text;
        this.talker = talker;
        this.receive = receive;
    }

    public SequenceNode(string text, int[] talkers){
        this.type = SequenceNodeType.DIALOG;
        this.text = text;
        this.talkers = talkers;
    }
}

public class SequenceManager : MonoBehaviour {
    static public SequenceManager S;
    public GameObject bola;

    public List<SequenceNode> current_sequence;

    void Awake(){
        S = this;
        this.current_sequence = null;
    }
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown (0)) {
            if (this.current_sequence != null && this.current_sequence.Count > 0) {
                SequenceNode current = current_sequence [0];
                current_sequence.Remove (current);
                runNode (current);
            }else
                Chat.S.fade_out (GameObject.Find("content"));
        } 
    }

    void runNode(SequenceNode sn){
        switch (sn.type) {
        case SequenceNodeType.SMS:
            if (sn.receive) {
                Chat.S.receiveMessage (sn.text,sn.talker);
            } else {
                Chat.S.sendMessage (sn.text);
            }
            break;
        case SequenceNodeType.DIALOG:
            Chat.S.talk (sn.talkers, sn.text);
            break;
        case SequenceNodeType.ACTION:
                shootBall ();
            break;
        }
    }

    void shootBall(){
        PrefabUtils.LoadPrefab (GameObject.Find ("Chat").transform, bola).GetComponent<PaperBall>().onHitPlayer = ()=>{
            GameObject.Find ("Background").GetComponent<Shake>().DoShake();
        };
    }
}
