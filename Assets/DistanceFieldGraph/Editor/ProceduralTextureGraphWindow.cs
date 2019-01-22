using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GraphProcessor;

public class ProceduralTextureGraphWindow : BaseGraphWindow
{

	[MenuItem("Window/03_CustomContextMenu")]
	public static BaseGraphWindow Open()
	{
		var graphWindow = GetWindow< ProceduralTextureGraphWindow >();

		graphWindow.Show();

		return graphWindow;
	}

	protected override void Initialize(BaseGraph graph)
	{
		titleContent = new GUIContent("Custom Toolbar Graph");

		var graphView = new ProceduralTextureGraphView();

		rootView.Add(graphView);

		graphView.Add(new ProceduralTextureToolbarView(graphView));
		graphView.Add(new MiniMapView(graphView));
	}
}
