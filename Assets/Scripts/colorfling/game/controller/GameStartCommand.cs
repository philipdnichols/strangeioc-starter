using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.opg.colorfling.game {
	public class GameStartCommand : Command {
		[Inject]
		public GameStartedSignal gameStartedSignal { get; set; }

		[Inject]
		public IGameModel gameModel { get; set; }

		[Inject]
		public IGameConfig gameConfig { get; set; }

		public override void Execute() {
			gameStartedSignal.Dispatch();
		}
	}
}