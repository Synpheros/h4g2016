using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room2 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("amistad", true, "Ventu",true));
        sequence.Add(new SequenceNode("-Ventu ha comentado en tu foto-\nEn esta foto das pena, jajajaja ", true, ""));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-\nXD ", false));
        sequence.Add(new SequenceNode("-Ventu ha comentado en tu foto-\nSi, XD ", true, ""));
        sequence.Add(new SequenceNode("-Ventu ha comentado en tu foto-\nYa verás mañana que risas", true, ""));
        sequence.Add(new SequenceNode("Mejor me voy a dormir...", false));
        sequence.Add (new SequenceNode ("Sleep"));

        SequenceManager.S.current_sequence = sequence;
    }

    // Update is called once per frame
    void Update () {

    }
}
