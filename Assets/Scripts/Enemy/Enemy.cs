using UnityEngine;
using System.Collections;

public class Enemy {

	private float _hitPoints;
	private float _speedMovement;
	private float _damage;
	private float _speedAttack;


	public virtual void attack()
	{

	}

	public virtual void move(Vector3 target)
	{

	}

	public virtual void die()
	{

	}

		
	public float hitPoints {
		get {
			return _hitPoints;
		}
		set {
			_hitPoints = value;
		}
	}

	public float speedMovement {
		get {
			return _speedMovement;
		}
		set {
			_speedMovement = value;
		}
	}

	public float damage {
		get {
			return _damage;
		}
		set {
			_damage = value;
		}
	}

	public float speedAttack {
		get {
			return _speedAttack;
		}
		set {
			_speedAttack = value;
		}
	}
}
