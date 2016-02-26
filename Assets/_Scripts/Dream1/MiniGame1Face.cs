using UnityEngine;

public class MiniGame1Face : MonoBehaviour {

	public float angle = 0;
	public int secodsToComplete = 5;
	public float radius = 5;
	private float speed;

	private Vector3 initPosition;
	private Vector3 nextPosition;

	private Animator animator;


	void Start()
	{
		animator = GetComponent<Animator>();
		this.initPosition = this.transform.localPosition;
        speed = (2 * Mathf.PI) / secodsToComplete; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	}

	void Update()
	{
		angle += speed * Time.deltaTime; //if you want to switch direction, use -= instead of +=
		nextPosition.x = initPosition.x + Mathf.Cos(angle) * radius;
		nextPosition.y = initPosition.y + Mathf.Sin(angle) * radius;

		this.transform.localPosition = nextPosition;
	}

	public void Clicked()
	{
		DestroyObject(this.gameObject);
	}

	void OnMouseDown()
	{
		animator.SetTrigger("expl");
		Invoke("Clicked", 1f);
	}
	
}
