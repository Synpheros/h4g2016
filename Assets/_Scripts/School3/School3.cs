﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class School3 : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        PrefabUtils.IS_DREAM_5 = false;
        List<SequenceNode> sequence = new List<SequenceNode> ();

		sequence.Add(new SequenceNode("Ventu: ¿Habéis visto la foto que comenté ayer?  ¡Das pena!", new int[] { -1, -1, 1 }));
		sequence.Add(new SequenceNode("Tu: Si sigues así la pienso borrar...", new int[] { -1, -1, -1 }));
        sequence.Add(new SequenceNode("Ventu: Borra lo que quieras, nada va a cambiar...", new int[] { -1, -1, 3 }));
        sequence.Add(new SequenceNode("Ventu: ¡Mirad! ¡Mirad!... ¡Está en su perfil social!", new int[] { -1, -1, 1 }));
        sequence.Add(new SequenceNode("Laughs"));
        sequence.Add(new SequenceNode("*Toda la clase rie a carcajadas*", new int[] { 31, 11, 1}));
		sequence.Add(new SequenceNode("Ventu: Y tú, Alicia, ten cuidado con quién te juntas, no vaya a pegarte su idiotez", new int[]{22,-1,1}));
        sequence.Add(new SequenceNode("Alicia: ...", new int[]{22,-1,1}));
        sequence.Add(new SequenceNode("Alicia: No te preocupes, yo estoy contigo...", new int[]{-1,21,-1}));
		sequence.Add(new SequenceNode("Teacher"));
		sequence.Add(new SequenceNode("Profesor: Empecemos la clase", new int[] { -1, 40, -1 }));
		sequence.Add(new SequenceNode("Position"));
        sequence.Add(new SequenceNode("Transition"));

		SequenceManager.S.current_sequence = sequence;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
