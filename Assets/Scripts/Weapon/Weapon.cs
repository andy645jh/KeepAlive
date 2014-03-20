using UnityEngine;
using System.Collections;

public class Weapon {

	private int _magazineCapacity;
	private int _ammo;
	private float _speedReload;
	private float _rateOfFire;


	public virtual void shoot()
	{

	}

	public virtual void reload()
	{

	}





	public int magazineCapacity {
		get {
			return _magazineCapacity;
		}
		set {
			_magazineCapacity = value;
		}
	}

	public int ammo {
		get {
			return _ammo;
		}
		set {
			_ammo = value;
		}
	}

	public float speedReload {
		get {
			return _speedReload;
		}
		set {
			_speedReload = value;
		}
	}

	public float rateOfFire {
		get {
			return _rateOfFire;
		}
		set {
			_rateOfFire = value;
		}
	}
}
