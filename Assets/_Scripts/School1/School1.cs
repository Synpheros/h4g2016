using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class School1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PrefabUtils.IS_DREAM_5 = false;
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("Profesor: Buenos días a todos chicos, ¿Que tal estáis hoy? Espero que muy bien.", new int[]{-1,40,-1}));
        sequence.Add(new SequenceNode("Profesor: Hoy es un gran día, ya que tenemos a un nuevo integrante en nuestra clase.", new int[]{-1,40,-1}));
        sequence.Add(new SequenceNode("Profesor: ¿Por que no te presentas?", new int[]{-1,40,-1}));

        sequence.Add(new SequenceNode("*Te pones de pies*", new int[]{-1,-1,-1}));
        sequence.Add(new SequenceNode("Tú: Hola... Buenos dias...", new int[]{-1,-1,-1}));
        sequence.Add(new SequenceNode("Tú: Soy...", new int[]{-1,-1,-1}));
        sequence.Add(new SequenceNode("Tú: Soy... Soy... Vengo...", new int[]{-1,-1,-1}));

        sequence.Add(new SequenceNode("*Cuchicheo inaudible*", new int[] {32, 4, -1}));
        sequence.Add(new SequenceNode("Tú: Y bueno... Eso...", new int[]{-1,-1,-1}));
        sequence.Add(new SequenceNode("Ventu: Madre mia... ¡Espabila!", new int[]{0,-1,-1}));

		sequence.Add(new SequenceNode("Profesor: ¡VENTU! ¡En silencio! ...Tranquilízate, no hace falta que sigas, seguro que con el tiempo haces muchos amigos.", new int[]{ -1, 40, -1 }));

        sequence.Add(new SequenceNode("Transition"));

		SequenceManager.S.current_sequence = sequence;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
