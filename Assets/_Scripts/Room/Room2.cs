using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room2 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("amistad", true, "Ventu",true));
        sequence.Add(new SequenceNode("-Ha comentado en tu foto-", true, "Ventu"));
        sequence.Add(new SequenceNode(" En esta foto das pena, jajajaja ", true, "Ventu"));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-", false));
        sequence.Add(new SequenceNode(" XD ", false));
        sequence.Add(new SequenceNode("-Ha comentado en tu foto-", true, "Ventu"));
        sequence.Add(new SequenceNode(" Si, XD ", true, "Ventu"));
        sequence.Add(new SequenceNode("Mejor me voy a dormir...", false));
        sequence.Add (new SequenceNode ("Sleep"));

        SequenceManager.S.current_sequence = sequence;
    }

    // Update is called once per frame
    void Update () {

    }
}
