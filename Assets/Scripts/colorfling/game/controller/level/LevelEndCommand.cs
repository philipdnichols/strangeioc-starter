using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.opg.colorfling.game {
	public class LevelEndCommand : Command {
		[Inject]
		public IGameModel gameModel { get; set; }

		public override void Execute() {

		}
	}
}