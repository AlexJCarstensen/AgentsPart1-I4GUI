using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Media.Animation;


namespace Delopgave4
{
    public class Agents : ObservableCollection<Agent>, INotifyPropertyChanged
    {
        public Agents()
        {
            Add(new Agent("001", "Nina", "Assassination", "UpperVolta"));
            Add(new Agent("007", "James Bond", "Martinis", "North Korea"));
            Add(new Agent("005", "Alex","Computer Engineering", "Making it work!"));
        }

#region Commands

        private ICommand _addCommand;
        public ICommand AddCommand => _addCommand ?? (_addCommand = new RelayCommand(AddAgent));
        
        private void AddAgent()
        {
            Add(new Agent());
            CurrentIndex = Count - 1;
        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
         => _deleteCommand ?? (_deleteCommand = new RelayCommand(AgentDelete, AgentDelete_Cane));

        private bool AgentDelete_Cane()
        {
            if (Count > 0 && CurrentIndex >= 0)
                return true;
            else
                return false;
        }

        private void AgentDelete()
        {
            RemoveAt(CurrentIndex);
        }


        private ICommand _nextCommand;

        public ICommand NextCommand
        {
            get
            {
                return _nextCommand ?? (_nextCommand = new RelayCommand(
                    () => ++CurrentIndex,
                    () => CurrentIndex < (Count - 1)));
            }
        }

        private ICommand _prevCommand;

        public ICommand PrevCommand
            => _prevCommand ?? (_prevCommand = new RelayCommand(PreviousCommandExecute, PreviousCommandCanExecute));

        private bool PreviousCommandCanExecute()
        {
            if (CurrentIndex > 0)
                return true;
            else
                return false;

        }

        private void PreviousCommandExecute()
        {
            if (CurrentIndex > 0)
                --CurrentIndex;
        }

#endregion //Commands

#region Properties

        public int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                if (_currentIndex != value)
                {
                    _currentIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }
#endregion //Properties

#region INotifyPropertyChanged implemetation

        public new event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
#endregion // INotifyPropertyChanged implemetation

#region Fields

        int _currentIndex = -1;

#endregion //Fields
    }  // Just to reference it from xaml

    

 

}

