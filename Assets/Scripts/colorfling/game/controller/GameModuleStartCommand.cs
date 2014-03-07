using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

namespace com.opg.colorfling.game {
	public class GameModuleStartCommand : Command {
		// This instantiates the game input
		[Inject]
		public IInput input { get; set; }
		
		public override void Execute() {
			// No-op
		}
	}
}