using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class School2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PrefabUtils.IS_DREAM_5 = false;
        List<SequenceNode> sequence = new List<SequenceNode> ();

        sequence.Add(new SequenceNode("Alicia: ...¿y cómo vienes hasta aquí todos los días?", new int[]{-1,21,-1}));
		sequence.Add(new SequenceNode("Tú: vengo andando con mi madre, me trae mi madre de camino al trabajo", new int[] { -1, -1, -1 }));
		sequence.Add(new SequenceNode("Ventu: Si, de la manita, no sea que se pierda de camino", new int[] { 22, -1,  1}));
        sequence.Add(new SequenceNode("*Toda la clase rie a carcajadas*", new int[] { 1, 11, 31}));
        sequence.Add(new SequenceNode("Laughs"));
		
		sequence.Add(new SequenceNode("Ventu: Y tú, Alicia, ten cuidado con quién te juntas, no vaya a pegarte su idiotez", new int[]{3,-1,22}));
		sequence.Add(new SequenceNode("Teacher"));
		sequence.Add(new SequenceNode("Profesor: Venga chichos, va a empezar la clase", new int[]{ -1, 40, -1 }));
		sequence.Add(new SequenceNode("Position"));
		//Todos miran hacía delante
		sequence.Add(new SequenceNode("Ventu: ¡Mira Aquí! ¡Pringao!", new int[]{-1,1,-1}));
		sequence.Add(new SequenceNode("ShootBall"));
		sequence.Add(new SequenceNode("Laugh"));
		sequence.Add(new SequenceNode("Ventu: Jajaj, en toda la boca", new int[] { -1, 1, -1 }));
        sequence.Add(new SequenceNode("Transition"));


		SequenceManager.S.current_sequence = sequence;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
