using System;
using UnityEngine;
using UOP1.StateMachine;
using UOP1.StateMachine.ScriptableObjects;
using Moment = UOP1.StateMachine.StateAction.SpecificMoment;

/// <summary>
/// Flexible StateActionSO for the StateMachine which allows to set any parameter on the Animator, in any moment of the state (OnStateEnter, OnStateExit, or each OnUpdate).
/// </summary>
[CreateAssetMenu(fileName = "ResetIsAttackingOnExit", menuName = "State Machines/Actions/Reset Is Attacking On Exit")]
public class ResetIsAttackingOnExitActionSO : StateActionSO<ResetIsAttackingOnExitAction>
{

}

public class ResetIsAttackingOnExitAction : StateAction
{
	private Protagonist _protagonist;

	public override void Awake(StateMachine stateMachine)
	{
		_protagonist = stateMachine.GetComponent<Protagonist>();
	}

	public override void OnStateExit()
	{
		_protagonist.attackInput = false;
	} 

	public override void OnUpdate() { }
}
