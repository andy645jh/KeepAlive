using UnityEngine;
using System.Collections;

public class SlowEnemy : Enemy  {

	private const float MAXIMUM_HIT_POINTS = 6;
	private const float MAXIMUM_SPEED_MOVEMENT = 3;
	private const float MAXIMUM_DAMAGE = 6;
	private const float	MAXIMUN_SPEED_ATTACK = 6;
	
	
	public SlowEnemy()
	{
		hitPoints = MAXIMUM_HIT_POINTS;
		speedMovement = MAXIMUM_SPEED_MOVEMENT;
		damage = MAXIMUM_DAMAGE;
		speedAttack = MAXIMUN_SPEED_ATTACK;
	}
	
}
