using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.signal.impl;
using strange.extensions.command.impl;

namespace reversi.game
{
	public class GameStartupCommand : Command
	{
		[Inject]
		public IResources resources { get; set; }

		[Inject]
		public IGameObject gameObject { get; set; }

		override public void Execute()
		{
			GameObject diskPrefab = resources.Load<GameObject>("Prefabs/Disk");

			for (int row = 0; row < 4; row++)
			{
				for (int col = 0; col < 4; col++)
				{
					GameObject cur = (GameObject)gameObject.Instantiate(diskPrefab);
					cur.transform.position = new Vector3(1f * col, 1f * row, 10f);
				}
			}
		}
	}
}