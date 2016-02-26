using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum SequenceNodeType {SMS, DIALOG};

public class SequenceNode{
    public SequenceNodeType type;
    public bool receive;
    public string text;
    public int[] takers;
}

public class SequenceManager : MonoBehaviour {
    static public SequenceManager S;

    public List<SequenceNode> current_sequence;


	void Start () {
        S = this;
        this.current_sequence = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.current_sequence != null && this.current_sequence.Count > 0) {
            if (Input.GetMouseButtonDown (0)) {
                SequenceNode current = current_sequence [0];
                current_sequence.Remove (current);
                runNode (current);
            }
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
            Chat.S.talk (sn.takers, sn.text);
            break;
        }
    }
}
