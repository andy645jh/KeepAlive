using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	private int _speed = 50;
	private float _friction = 0.9f;
	private float _lerpSpeed = 1;
	private float _xDeg;
	private float _yDeg;
	private float _zDeg;
	private Quaternion _fromRotation;
	private Quaternion _toRotation;
	private Camera cam;
	private Vector3 direction;
	public Transform target;
	public float rotationSpeed = 10;
	private float cont = 0;
	private GameObject _cilindroActual;

	void Start ()
	{
		
	}

	void Update ()
	{
		// perseguidor
		//Vector3 vel_vec = target.position - transform.position; // Creamos un vector desde el perseguidor
		//transform.LookAt(target); // hasta el objetivo y cambiamos su direccion
		//transform.Translate(Vector3.forward * _speed * Time.deltaTime); // Anda hacia su objetivo 


		if(Input.GetMouseButton(0)) 
		{
			cont++;
			GameObject cilindro =(GameObject) Instantiate( Resources.Load("Prefabs/Cylinder"));
			cilindro.name = "Cilindro_"+cont;
			cilindro.transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, transform.position.z));
			cilindro.transform.localScale = new Vector3(50,50,50);

			_cilindroActual = cilindro;
		
		}

		if(_cilindroActual != null)
		{
			transform.LookAt(_cilindroActual.transform);
		}
	}
}
