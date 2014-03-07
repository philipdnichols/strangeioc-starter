using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

namespace com.opg.colorfling.game {
	public class GameContext : SignalContext {
		public GameContext(MonoBehaviour contextView) : base(contextView) {}

		protected override void mapBindings() {
			base.mapBindings();

#if !UNITY_EDITOR && (UNITY_IPHONE || UNITY_ANDROID)
			// We might want onscreen controls:
			injectionBinder.Bind<IInput>().To<NullInput>().ToSingleton();

			// Or we might want touch controls:
			injectionBinder.Bind<IInput>().To<TouchInput>().ToSingleton();
#else
			injectionBinder.Bind<IInput>().To<KeyboardAndMouseInput>().ToSingleton();
#endif

			if (Context.firstContext == this) {
				injectionBinder.Bind<IGameModel>().To<GameModel>().ToSingleton();
			}

			injectionBinder.Bind<GameStartedSignal>().ToSingleton();
			injectionBinder.Bind<LevelStartedSignal>().ToSingleton();

			if (Context.firstContext == this) {
				injectionBinder.Bind<GameInputSignal>().ToSingleton();
			}

			if (Context.firstContext == this) {
				//Standalone
				commandBinder.Bind<StartSignal>().To<GameIndependentStartGameCommand>().Once();
			} else {
				// Multi-Context
				commandBinder.Bind<StartSignal>().To<GameModuleStartCommand>().Once();
			}

			commandBinder.Bind<GameStartSignal>().To<GameStartCommand>();
			commandBinder.Bind<GameEndSignal>().To<GameEndCommand>();

			commandBinder.Bind<LevelStartSignal>()
				.To<LevelStartCommand>()
					.InSequence();

			commandBinder.Bind<LevelEndSignal>()
				.To<LevelEndCommand>()
					.InSequence();

			mediationBinder.Bind<GameDebugView>().To<GameDebugMediator>();
		}

		protected override void postBindings() {
			Camera camera = ((GameObject) contextView).GetComponentInChildren<Camera>();
			if (camera == null) {
				throw new UnityException("GameContext couldn't find the Game Camera");
			}
			injectionBinder.Bind<Camera>().ToValue(camera).ToName(CommonElement.GameCamera);

			base.postBindings ();
		}
	}
}