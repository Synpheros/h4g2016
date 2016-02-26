using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SequenceNodeType {SMS, DIALOG};

public class SequenceNode{
    public SequenceNodeType type;
    public bool receive;
    public string text;
    public int[] talkers;

    public SequenceNode(string text, bool receive){
        this.type = SequenceNodeType.SMS;
        this.text = text;
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
                Chat.S.receiveMessage (sn.text);
            } else {
                Chat.S.sendMessage (sn.text);
            }
            break;
        case SequenceNodeType.DIALOG:
            Chat.S.talk (sn.talkers, sn.text);
            break;
        }
    }
}
