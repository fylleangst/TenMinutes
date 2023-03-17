using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Input;
using TenMinutes.Annotations;

namespace TenMinutes
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		private string _title;
		private string _icon;
		private Timer _theTide;
		private string _infoText;
		private string _additionalInfoText;
		private bool canExecute = true;
		private string _stuffDone;

		public MainWindowViewModel()
		{
			GetNewTask = new RelayCommand(TestTask, param => canExecute);
			InfoText = "Press when ready";
			TitleString = "Ten minutes";
			Icon = "Resources/Icons/Ready.png";
		}

		public void TestTask(object obj)
		{
			var newTask = NewTask();
			var hint = HintsAndTips();

			Countdown(newTask, hint);
			canExecute = false;
		}

		public void Countdown(string task, string hint)
		{
			var tid = 10;
			InfoText = $"The next {tid}m. : {task}";

			TitleString = $"{task}";
			AdditionalInfoText = $"{hint}";

			StuffDone = task + "; " + StuffDone;

			Icon = "Resources/Icons/done.png";

			_theTide = new Timer {Interval = tid * 1000 * 60};

			_theTide.Elapsed += StopCounter;

			_theTide.Enabled = true;
			_theTide.Start();
		}

		public void StopCounter(object sender, ElapsedEventArgs e)
		{
			_theTide.Stop();
			canExecute = true;
			EndTask();
		}

		public string NewTask()
		{
			var dices = new Dices();
			var task = new Tasks();

			var whatToDo = task.GetMainTasks(dices.D100());

			return whatToDo;
		}

		public string HintsAndTips()
		{
			var hints = new Tasks();
			var hintsAndTips = string.Empty;

			hintsAndTips = hints.SomeHintsAndTips();

			return hintsAndTips;
		}


		public void EndTask()
		{

			InfoText = $"Cool cool cool. Now do something else?";
			AdditionalInfoText = string.Empty;
			TitleString = $"Finished";
			Icon = "Resources/Icons/Ready.png";
		}

		public string InfoText
		{
			get => _infoText;
			set
			{
				_infoText = value;
				OnPropertyChanged(nameof(InfoText));
			}
		}

		public string AdditionalInfoText
		{
			get => _additionalInfoText;
			set
			{
				_additionalInfoText = value;
				OnPropertyChanged(nameof(AdditionalInfoText));
			}
		}

		public ICommand GetNewTask
		{
			get;
			set;
		}
		public string TitleString
		{
			get => _title;
			set
			{
				_title = value;
				OnPropertyChanged(nameof(TitleString));
			}
		}

		public string StuffDone
		{
			get => _stuffDone;
			set
			{
				_stuffDone = value;
				OnPropertyChanged(nameof(StuffDone));
			}
		}

		public string Icon
		{
			get => _icon;
			set
			{
				_icon = value;
				OnPropertyChanged(nameof(Icon));
			}
		}

		public string ButtonText => "Press";

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
