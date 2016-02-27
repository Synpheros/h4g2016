using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room4 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("notificacion", true, "¡Te han etiquetado en una foto!",true));
        sequence.Add(new SequenceNode("-Ventu ha comentado en tu foto-\n¡Jajaj, eso eso, etiquetadle en todas!", true, ""));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-\n¡OTRA VEZ! ¡¿POR QUE?!", false));
        sequence.Add(new SequenceNode("notificacion", true, "¡Te han etiquetado en una foto!",true));
        sequence.Add(new SequenceNode("notificacion", true, "¡Te han etiquetado en una foto!",true));
        sequence.Add(new SequenceNode("-Alicia ha comentado en tu foto-\n¡Dejadle en paz!", true, ""));
        sequence.Add(new SequenceNode("-Ventu ha comentado en tu foto-\n...Te lo advertí Alicia.", true, ""));
        sequence.Add(new SequenceNode("-Valentín ha comentado en tu foto-\nAdemás de Fea, tonta.", true, ""));
        sequence.Add(new SequenceNode("-Teresa ha comentado en tu foto-\nQue pasa ¿Es tu novio?", true, ""));
        sequence.Add(new SequenceNode("-Raúl ha comentado en tu foto-\nEres tan inútil como el.", true, ""));
        sequence.Add(new SequenceNode("-Miguel ha comentado en tu foto-\nEs que con esa cara jjaja", true, ""));
        sequence.Add(new SequenceNode("-Nerea ha comentado en tu foto-\nMoriros ya.", true, ""));
        sequence.Add(new SequenceNode("-Ventu ha comentado en tu foto-\nExactamente...", true, ""));
        sequence.Add(new SequenceNode("Alicia, No me dejes :(", false));
        sequence.Add(new SequenceNode("No se si podré aguantar...", true, "Alicia"));
        sequence.Add(new SequenceNode("Por favor... No me abandones...", false));
        sequence.Add(new SequenceNode (" ... ", true, "Alicia"));
        sequence.Add(new SequenceNode ("Sleep"));

        SequenceManager.S.current_sequence = sequence;
    }

    // Update is called once per frame
    void Update () {

    }
}
