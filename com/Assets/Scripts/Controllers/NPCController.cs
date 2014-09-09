﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCController : BaseController 
{
	private TaskController taskController = null;
	public GameObject[] destinations;

	/// <summary>
	/// Starts the controller.
	/// </summary>
	protected override void StartController()
	{
		destinations = GameObject.FindGameObjectsWithTag ("Destination");
		taskController = new TaskController (this.gameObject);
	}

	/// <summary>
	/// Updates the controller.
	/// </summary>
	protected override void UpdateController ()
	{
		taskController.UpdateTasks ();
	}
}