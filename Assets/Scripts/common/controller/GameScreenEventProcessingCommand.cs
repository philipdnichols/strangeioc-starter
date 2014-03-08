using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.opg.colorfling.common {
	public class GameScreenEventProcessingCommand : Command {
		[Inject]
		public GameScreenEvent gameScreenEvent { get; set; }

		[Inject]
		public GameScreenSizeChangedSignal gameScreenSizeChangedSignal { get; set; }

		public override void Execute() {
			switch (gameScreenEvent) {
			case GameScreenEvent.ScreenSizeChanged:
				gameScreenSizeChangedSignal.Dispatch();
				break;

			case GameScreenEvent.Null:
			default:
				break;
			}
		}
	}
}