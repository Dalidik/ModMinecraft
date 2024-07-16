using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
	public RectTransform MainMenu, ModsMenu, InstructionMenu, PolicyMenu;

	private void Start()
	{
		MainMenu.DOAnchorPos(Vector2.zero, 0.25f);
	}

	public void ModsMenuButton()
	{
		MainMenu.DOAnchorPos(new Vector2(1308, 0), 0.25f);
		ModsMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
	}

	public void CloseModsMenuButton()
	{
		MainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f);
		ModsMenu.DOAnchorPos(new Vector2(-1308, 0), 0.25f);
	}

	public void InstructionMenuButton()
	{
		MainMenu.DOAnchorPos(new Vector2(1308, 0), 0.25f);
		InstructionMenu.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
	}

	public void CloseInstructionMenuButton()
	{
		InstructionMenu.DOAnchorPos(new Vector2(-1308, 0), 0.25f);
		MainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
	}

	public void PolicyMenuButton()
	{
		MainMenu.DOAnchorPos(new Vector2(0, -1703), 0.25f);
		PolicyMenu.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
	}

	public void ClosePolicyMenuButton()
	{
		PolicyMenu.DOAnchorPos(new Vector2(-0, 1703), 0.25f);
		MainMenu.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);
	}
}
