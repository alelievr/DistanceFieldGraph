using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GraphProcessor;
using UnityEditor.Callbacks;

public class GraphAssetCallbacks
{
	[MenuItem("Assets/Create/Procedural Texture Graph", false, 10)]
	public static void CreateGraphPorcessor()
	{
		var		obj = Selection.activeObject;
		string	path;

		if (obj == null)
			path = "Assets";
		else
			path = AssetDatabase.GetAssetPath(obj.GetInstanceID());

		var graph = ScriptableObject.CreateInstance< ProceduralTextureGraph >();
		ProjectWindowUtil.CreateAsset(graph, path + "/ProceduralTextureGraph.asset");
	}

	[OnOpenAsset(0)]
	public static bool OnBaseGraphOpened(int instanceID, int line)
	{
		var asset = EditorUtility.InstanceIDToObject(instanceID);

		if (asset is ProceduralTextureGraph)
		{
			var win = ProceduralTextureGraphWindow.GetWindow< ProceduralTextureGraphWindow >();

			win.Show();

			win.InitializeGraph(asset as ProceduralTextureGraph);
			return true;
		}
		return false;
	}
}
