using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GraphProcessor;

[CustomEditor(typeof(BaseGraph))]
public class GraphAssetInspector : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
	}
}
