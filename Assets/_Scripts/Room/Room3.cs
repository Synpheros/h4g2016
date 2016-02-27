using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room3 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("-Ventu Ha comentado en tu foto-\n\t¡Que tonto eres!", true, ""));
        sequence.Add(new SequenceNode("-Ventu Ha comentado en tu foto-\n\tQue tonto eres", true, ""));
        sequence.Add(new SequenceNode("-Alicia Ha comentado en tu foto-\n\t¡Déjale en paz!", true, ""));
        sequence.Add(new SequenceNode("-Ventu Ha comentado en tu foto-\n\tQue tonto eres", true, ""));
        sequence.Add(new SequenceNode("-Juanma Ha comentado en tu foto-\n\tQue tonto eres", true, ""));
        sequence.Add(new SequenceNode("-Paloma Ha comentado en tu foto-\n\tQue tonto eres", true, ""));
        sequence.Add(new SequenceNode("-Valentín Ha comentado en tu foto-", true, ""));
        sequence.Add(new SequenceNode("-Raúl Ha comentado en tu foto-", true, ""));
        sequence.Add(new SequenceNode("-Marta Ha comentado en tu foto-", true, ""));
        sequence.Add(new SequenceNode("-Antonio Ha comentado en tu foto-", true, ""));
        sequence.Add(new SequenceNode("-Teresa Ha comentado en tu foto-", true, ""));
        sequence.Add(new SequenceNode("-Iván Ha comentado en tu foto-", true, ""));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-", false));
        sequence.Add(new SequenceNode("Por favor, ¡Parad ya!", false));
        sequence.Add(new SequenceNode("-Miguel Ha comentado en tu foto-", true, "Miguel"));
        sequence.Add(new SequenceNode("-Nerea Ha comentado en tu foto-", true, "Nerea"));
        sequence.Add(new SequenceNode("-Juanma Ha comentado en tu foto-", true, "Juanma"));

        sequence.Add(new SequenceNode("Mejor voy a borrar la foto...", false));
        sequence.Add(new SequenceNode("borrar", true, "",true));

        sequence.Add(new SequenceNode("-Tu foto ha sido borrada-", true, "Sistema"));


        sequence.Add(new SequenceNode("Por fin se acabó la pesadilla...", false));
        sequence.Add (new SequenceNode ("Sleep"));

        SequenceManager.S.current_sequence = sequence;
    }

    // Update is called once per frame
    void Update () {

    }
}
