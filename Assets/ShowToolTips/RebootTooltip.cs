﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RebootTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
 {
    private bool mouse_over = false;
	public Tooltip tp;
	
	void Update()
	{
		if (mouse_over)
		{
			//tp.ShowTooltip("Freeze");
		}
	}
 
	public void OnPointerEnter(PointerEventData eventData)
	{
		mouse_over = true;
		tp.ShowTooltip("QUICK REBOOT THE SYSTEM: $1000");
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		mouse_over = false;
		tp.HideTooltip();
	}

	/*private Tooltip tp;
	
	void Start() {
		tp = GameObject.FindObjectOfType<Tooltip>();
	}
	
    void OnPointerEnter(PointerEventData eventData) {
		print("You moused over freeze");
		tp.ShowTooltip("Freeze");
	}
	
	void OnMouseExit() {
		print("You left freeze");
		tp.HideTooltip();
	}*/
}
