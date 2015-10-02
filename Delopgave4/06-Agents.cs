using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Delopgave4
{
        public class Agents : ObservableCollection<Agent>
        {
            public Agents()
            {
                Add(new Agent("001", "Nina", "Assassination", "UpperVolta"));
                Add(new Agent("007", "James Bond", "Martinis", "North Korea"));
            }
        };  // Just to reference it from xaml
    }

