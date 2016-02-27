using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class School4 : MonoBehaviour
{

	// Use this for initialization
	void Start()
    {
        PrefabUtils.IS_DREAM_5 = false;
        List<SequenceNode> sequence = new List<SequenceNode>();

		sequence.Add(new SequenceNode("Ventu: ya ha llegado el cobarde... ayer borró su foto.", new int[] { -1, -1,  1}));
		sequence.Add(new SequenceNode("Armando: Jajaja sí sí, esa foto tan penosa", new int[] { -1, 31, 0 }));
		sequence.Add(new SequenceNode("Inés: ya ves, jaja", new int[] {11, 30, 0 }));
		sequence.Add(new SequenceNode("Ventu: pero no pasa nada porque tengo preparada una sorpresa para él.", new int[] { 10, 30, 1 }));
		sequence.Add(new SequenceNode("Teacher"));
		sequence.Add(new SequenceNode("Profesor: Empezamos la clase", new int[] { -1, 40, -1 }));
		sequence.Add(new SequenceNode("Position"));
        sequence.Add(new SequenceNode("Transition"));

		SequenceManager.S.current_sequence = sequence;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
