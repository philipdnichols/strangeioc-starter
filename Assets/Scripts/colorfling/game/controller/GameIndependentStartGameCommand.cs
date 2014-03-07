using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

namespace com.opg.colorfling.game {
	public class GameIndependentStartGameCommand : Command {
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView { get; set; }

		// This instantiates the game input
		[Inject]
		public IInput input { get; set; }

		public override void Execute() {
			GameObject go = new GameObject("DebugView");
			go.AddComponent<GameDebugView>();
			go.transform.parent = contextView.transform;
		}
	}
}