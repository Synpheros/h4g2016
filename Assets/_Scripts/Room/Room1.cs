using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room1 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("amistad", true, "Alicia",true));
        sequence.Add(new SequenceNode("Hola, me llamo Alicia", true, "Alicia"));
        sequence.Add(new SequenceNode("No te preocupes por lo de clase", true, "Alicia"));
        sequence.Add(new SequenceNode("A mi me has caido genial :)", true));
        sequence.Add(new SequenceNode("Gracias :)", false));
        sequence.Add(new SequenceNode("Tu a mi también :)", false));

        sequence.Add(new SequenceNode("amistad", true, "Inés",true));
        sequence.Add(new SequenceNode("¡Bienvenido al cole!", true, "Inés"));
        sequence.Add(new SequenceNode("Jejej, gracias :)", false));

        sequence.Add(new SequenceNode("amistad", true, "Armando",true));
        sequence.Add(new SequenceNode("Hey! Vaya cortazo hoy, ehh", true, "Inés"));
        sequence.Add(new SequenceNode("Ya... No me lo recuerdes...", false));

        sequence.Add(new SequenceNode("Me voy a dormir... ¡Hasta mañana!", false));

        sequence.Add (new SequenceNode ("Sleep"));

        SequenceManager.S.current_sequence = sequence;
    }

    // Update is called once per frame
    void Update () {

    }
}
