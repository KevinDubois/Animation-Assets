using UnityEngine;
using System.Collections;

public class unicycleAnimation : MonoBehaviour {

	public float speed;
	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetFloat("speed", speed);
	
	}
}
