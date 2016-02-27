using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class School5 : MonoBehaviour
{

	// Use this for initialization
	void Start()
    {
        PrefabUtils.IS_DREAM_5 = false;
        List<SequenceNode> sequence = new List<SequenceNode>();

		sequence.Add(new SequenceNode("Ventu: Sorpresa!!! A ver qué te parece la nueva decoración de la clase!", new int[] { -1, -1, 1 }));
		sequence.Add(new SequenceNode("Armando: Si, te acuerdas de la imagen de anoche??? Esa que borraste.", new int[] { 30, -1, 1 }));
		sequence.Add(new SequenceNode("Ventu: Jajaj, eres patético, díselo Alicia, dile lo triste que es.", new int[] { 0, -1, -1 }));
		sequence.Add(new SequenceNode("Alicia: Eres un perdedor, no te molestes en hablarme más", new int[] { 0, -1, 20 }));
		sequence.Add(new SequenceNode("Inés: No sé para qué vienes a clase, no te va a servir de nada", new int[] { 0, 10, 20 }));
		sequence.Add(new SequenceNode("Teacher"));
		sequence.Add(new SequenceNode("Profesor: Buenos días, empecemos con la clase de hoy ", new int[] { -1, 40, -1 }));
		sequence.Add(new SequenceNode("Position"));
		sequence.Add(new SequenceNode("Transition"));

        SequenceManager.S.current_sequence = sequence;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
