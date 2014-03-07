using UnityEngine;
using System.Collections;

namespace com.opg.colorfling.game {
	public class GameConfig : IGameConfig {
		public GameConfig() {}

		[PostConstruct]
		public void PostConstruct() {
			// TextAsset gameConfigFile = (TextAsset) Resources.Load("gameConfig");

			// SimpleJSON.JSONNode n = SimpleJSON.JSON.Parse(gameConfigFile.text);
		}

		#region IGameConfig Implementation

		#endregion
	}
}