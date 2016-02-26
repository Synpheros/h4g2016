using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        SequenceNode sn = new SequenceNode ()
            ,sn2 = new SequenceNode ()
            ,sn3 = new SequenceNode ()
            ,sn4 = new SequenceNode ()
            ,sn5 = new SequenceNode ()
            ,sn6 = new SequenceNode ();

        sn.type = SequenceNodeType.SMS;
        sn.receive = true;
        sn.text = "Hola, soy Tomás, el del colegio";
        sequence.Add (sn);

        sn2.type = SequenceNodeType.SMS;
        sn2.receive = true;
        sn2.text = "¿Te acuerdas de mi? ¿Que tal?";
        sequence.Add (sn2);

        sn3.type = SequenceNodeType.SMS;
        sn3.receive = false;
        sn3.text = "Si, me acuerdo de ti, jeje";
        sequence.Add (sn3);

        sn4.type = SequenceNodeType.SMS;
        sn4.receive = false;
        sn4.text = "Me caiste muy bien :)";
        sequence.Add (sn4);

        sn5.type = SequenceNodeType.SMS;
        sn5.receive = true;
        sn5.text = "Tu a mi también, aunque a mis amigos no tanto...";
        sequence.Add (sn5);

        SequenceManager.S.current_sequence = sequence;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
