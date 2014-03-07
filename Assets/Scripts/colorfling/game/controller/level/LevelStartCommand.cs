using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.opg.colorfling.game {
	public class LevelStartCommand : Command {
		[Inject]
		public IGameModel gameModel { get; set; }

		[Inject]
		public LevelStartedSignal levelStartedSignal { get; set; }

		public override void Execute() {
			levelStartedSignal.Dispatch();
		}
	}
}