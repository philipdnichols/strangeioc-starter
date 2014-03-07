using strange.extensions.mediation.impl;

namespace com.opg.colorfling.game {
	public class GameDebugMediator : Mediator {
		[Inject]
		public GameDebugView view { get; set; }

		// Signals
		[Inject]
		public GameStartSignal gameStartSignal { get; set; }

		[Inject]
		public GameEndSignal gameEndSignal { get; set; }

		[Inject]
		public LevelStartSignal levelStartSignal { get; set; }

		[Inject]
		public LevelStartedSignal levelStartedSignal { get; set; }

		[Inject]
		public GameStartedSignal gameStartedSignal { get; set; }

		public override void OnRegister() {
			view.startGameSignal.AddListener(OnStartGameClick);
			view.startLevelSignal.AddListener(OnStartLevelClick);

			gameStartedSignal.AddListener(OnGameStarted);
			gameEndSignal.AddListener(OnGameEnded);
			levelStartedSignal.AddListener(OnLevelStarted);
		}

		public override void OnRemove() {
			view.startGameSignal.RemoveListener(OnStartGameClick);
			view.startLevelSignal.RemoveListener(OnStartLevelClick);
			
			gameStartedSignal.RemoveListener(OnGameStarted);
			gameEndSignal.RemoveListener(OnGameEnded);
			levelStartedSignal.RemoveListener(OnLevelStarted);
		}

		private void OnStartGameClick() {
			gameStartSignal.Dispatch();
		}

		private void OnStartLevelClick() {
			levelStartSignal.Dispatch();
		}

		private void OnGameStarted() {
			// Manipulate the view
		}

		private void OnGameEnded() {
			// Manipulate the view
		}

		private void OnLevelStarted() {
			// Manipulate the view
		}
	}
}