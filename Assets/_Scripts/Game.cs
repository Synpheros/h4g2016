using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {

    public GameObject bola;

	// Use this for initialization
	void Start () {
        List<SequenceNode> sequence = new List<SequenceNode> ();

        /*sn.type = SequenceNodeType.SMS;
        sn.receive = true;
        sn.text = "Hola, soy Tomás, el del colegio";
        sequence.Add (sn);

        sn2.type = SequenceNodeType.SMS;
        sn2.receive = true;
        sn2.text = "¿Te acuerdas de mi? ¿Que tal?";
        sequence.Add (sn2);

        sn3.type = SequenceNodeType.SMS;
        sn3.receive = false;
        sn3.text = "Si, me acuerdo de ti, jeje";
        sequence.Add (sn3);

        sn4.type = SequenceNodeType.SMS;
        sn4.receive = false;
        sn4.text = "Me caiste muy bien :)";
        sequence.Add (sn4);

        sn5.type = SequenceNodeType.SMS;
        sn5.receive = true;
        sn5.text = "Tu a mi también, aunque a mis amigos no tanto...";
        sequence.Add (sn5);*/

        sequence.Add (new SequenceNode ("ShootBall"));
        sequence.Add (new SequenceNode ("Sleep"));
        sequence.Add(new SequenceNode("Ventu", true, "Ventu",true));
        sequence.Add(new SequenceNode("-Ha comentado en tu foto-", true, "Ventu"));
        sequence.Add(new SequenceNode("\"En esta foto das pena, jajajaja\"", true, "Tomas"));
        sequence.Add(new SequenceNode("-Has comentado en tu foto-", false));
        sequence.Add(new SequenceNode("\"X'D\"", false));
        sequence.Add(new SequenceNode("-Ha comentado en tu foto-", true, "Ventu"));
        sequence.Add(new SequenceNode("\"Si, XD\"", true, "Ventu"));

        /*sequence.Add(new SequenceNode("Hola, soy Tomás, el del colegio", false));
        sequence.Add(new SequenceNode("Hola, soy Tomás, el del colegio", true, "Tomas"));*/

        /*sequence.Add(new SequenceNode("Tomas: Hey, me llamo Tomás, y soy el más guay de por aquí, no vas a encontrar a nadie tan guay", new int[]{-1,3,-1}));
        sequence.Add (new SequenceNode ("ShootBall"));
        sequence.Add(new SequenceNode("Sandra: Anda, cállate Tomás, si no eres más que un tonto... Yo me llamo Sandra, y si que soy la más guay", new int[]{3,-1,1}));
        sequence.Add(new SequenceNode("Tu: ¡NO OS METAIS CON TOMAS!", new int[]{-1,-1,-1}));
        sequence.Add(new SequenceNode("Tomas: Jopé Sandra... Tu siempre igual... Me haces sentir fatal", new int[]{3,-1,1}));
        sequence.Add(new SequenceNode("Sandra: Bueno, nos veremos por aquí, ¡Hasta Pronto!", new int[]{3,-1,1}));
        sequence.Add(new SequenceNode("Tomas: Odio a Sandra, pero aún así estoy enamorado de ella.", new int[]{-1,3,-1}));*/




        SequenceManager.S.current_sequence = sequence;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
