using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room3 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("-Ventu Ha comentado en tu foto-\n¡Que tonto eres!", true, ""));
        sequence.Add(new SequenceNode("-Armando Ha comentado en tu foto-\nJajajaja, ¡Veeentu!", true, ""));
        sequence.Add(new SequenceNode("-Ventu Ha comentado en tu foto-\nEres el mejor, no como este bobo.", true, ""));
        sequence.Add(new SequenceNode("-Alicia Ha comentado en tu foto-\n¡Déjadle en paz!", true, ""));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-\nGracias :)", false));
        sequence.Add(new SequenceNode("-Ventu Ha comentado en tu foto-\nTu calla, o irás después", true, ""));
        sequence.Add(new SequenceNode("-Inés Ha comentado en tu foto-\nJajaja, Alicia perdedora.", true, ""));
        sequence.Add(new SequenceNode("-Alicia Ha comentado en tu foto-\n...", true, ""));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-\nPor favor, ¡Parad ya!", false));
        sequence.Add(new SequenceNode("-Alicia Ha comentado en tu foto-\nIntenta ignorarles... Es mejor...", true, ""));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-\nMejor voy a borrar la foto...", false));
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
