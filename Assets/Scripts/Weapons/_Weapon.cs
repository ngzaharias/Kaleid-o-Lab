﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class _Weapon : MonoBehaviour {

	public float damage;
	public float cooldown;
	
	protected float timer = 0.0f;

	void Update() {
		timer += Time.deltaTime;
	}

	public virtual void Shoot() {	

		if (timer >= cooldown) {
			timer = 0.0f;
			
			foreach (Transform child in transform) {
				if (child.GetComponent<Weapon_Shoot>()) {
					child.GetComponent<Weapon_Shoot>().Shoot(damage);
				}
			}			
		}
	}
}
