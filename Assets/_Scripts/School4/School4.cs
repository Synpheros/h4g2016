using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class School4 : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		List<SequenceNode> sequence = new List<SequenceNode>();

		sequence.Add(new SequenceNode("Ventu: ya ha llegado el cobarde... ayer borró su foto.", new int[] { -1, 0, -1 }));
		sequence.Add(new SequenceNode("Armando: Jajaja sí sí, esa foto en la que tenía cara de retrasado", new int[] { -1, -1, -1 }));
		sequence.Add(new SequenceNode("Alicia: ya ves, jaja", new int[] { -1, 3, -1 }));
		sequence.Add(new SequenceNode("Ventu: pero no pasa nada porque tengo preparada una sorpresa para él.", new int[] { -1, 3, -1 }));
		sequence.Add(new SequenceNode("Profesor: Empezamos la clase", new int[] { -1, 40, -1 }));
		sequence.Add(new SequenceNode("Teacher"));

		SequenceManager.S.current_sequence = sequence;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
