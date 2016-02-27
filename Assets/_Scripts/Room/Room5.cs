using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room5 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

		sequence.Add(new SequenceNode("Venga, me das pena, quitales 50€ a tu padres", true, "Ventu"));
        sequence.Add(new SequenceNode("y traemelos mañana", true, "Ventu"));

        sequence.Add(new SequenceNode("Entonces haré que todos borren las fotos", true, "Ventu"));
        sequence.Add(new SequenceNode("y nos olvidemos del tema", true, "Ventu"));

		sequence.Add(new SequenceNode("De acuerdo, te los llevaré mañana", false));
		sequence.Add(new SequenceNode("Así me gusta, pero esto no termina aquí", true, "Ventu"));
		sequence.Add(new SequenceNode("Estoy deseando verte el próximo día en clase", true, "Ventu"));
        sequence.Add(new SequenceNode("tendrás que hacer más cosas para mi...", true, "Ventu"));
        sequence.Add(new SequenceNode("si no quieres que vuelva a compartir la foto", true, "Ventu"));
		sequence.Add(new SequenceNode("O sino la volveré a subir", true, "Ventu"));
		sequence.Add(new SequenceNode ("Sleep"));

        SequenceManager.S.current_sequence = sequence;
    }

    // Update is called once per frame
    void Update () {

    }
}
