﻿#pragma strict

var anim: Animation;

function Start() {
	anim = GetComponent.<Animation>();
}

// Make the character fade between an idle and a run animation 
// when the player starts to move.
function Update () {
	if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.000001 ||
		Mathf.Abs(Input.GetAxis("Horizontal")) > 0.000001)
	{
		anim["run"].speed = 1.5f;
		anim.CrossFade("run");
	}
	else
	{
		anim["run"].speed = 1.5f;
		anim.CrossFade("idle");
	}
}