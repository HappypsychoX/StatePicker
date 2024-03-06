using System.Windows.Controls;

namespace StatePicker
{
    /// <summary>
    /// Interaction logic for StatePicker.xaml
    /// </summary>
    public partial class StatePicker : ComboBox
    {

        public StatePicker()
        {
            InitializeComponent();
            StateList stateList = new StateList();
            this.ItemsSource = stateList.States;
            this.SelectedValuePath = "Abbreviation";
        }
    }

    public class State
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }

    public class StateList
    {
        public List<State> States { get; set; }
        public StateList()
        {
            States = new List<State>();
            States.Add(new State() { Name = "Alabama", Abbreviation = "AL" });
            States.Add(new State() { Name = "Alaska", Abbreviation = "AK" });
            States.Add(new State() { Name = "Arizona", Abbreviation = "AZ" });
            States.Add(new State() { Name = "Arkansas", Abbreviation = "AR" });
            States.Add(new State() { Name = "California", Abbreviation = "CA" });
            States.Add(new State() { Name = "Colorado", Abbreviation = "CO" });
            States.Add(new State() { Name = "Connecticut", Abbreviation = "CT" });
            States.Add(new State() { Name = "Delaware", Abbreviation = "DE" });
            States.Add(new State() { Name = "Florida", Abbreviation = "FL" });
            States.Add(new State() { Name = "Georgia", Abbreviation = "GA" });
            States.Add(new State() { Name = "Hawaii", Abbreviation = "HI" });
            States.Add(new State() { Name = "Idaho", Abbreviation = "ID" });
            States.Add(new State() { Name = "Illinois", Abbreviation = "IL" });
            States.Add(new State() { Name = "Indiana", Abbreviation = "IN" });
            States.Add(new State() { Name = "Iowa", Abbreviation = "IA" });
            States.Add(new State() { Name = "Kansas", Abbreviation = "KS" });
            States.Add(new State() { Name = "Kentucky", Abbreviation = "KY" });
            States.Add(new State() { Name = "Louisiana", Abbreviation = "LA" });
            States.Add(new State() { Name = "Maine", Abbreviation = "ME" });
            States.Add(new State() { Name = "Maryland", Abbreviation = "MD" });
            States.Add(new State() { Name = "Massachusetts", Abbreviation = "MA" });
            States.Add(new State() { Name = "Michigan", Abbreviation = "MI" });
            States.Add(new State() { Name = "Minnesota", Abbreviation = "MN" });
            States.Add(new State() { Name = "Mississippi", Abbreviation = "MS" });
            States.Add(new State() { Name = "Missouri", Abbreviation = "MO" });
            States.Add(new State() { Name = "Montana", Abbreviation = "MT" });
            States.Add(new State() { Name = "Nebraska", Abbreviation = "NE" });
            States.Add(new State() { Name = "Nevada", Abbreviation = "NV" });
            States.Add(new State() { Name = "New Hampshire", Abbreviation = "NH" });
            States.Add(new State() { Name = "New Jersey", Abbreviation = "NJ" });
            States.Add(new State() { Name = "New Mexico", Abbreviation = "NM" });
            States.Add(new State() { Name = "New York", Abbreviation = "NY" });
            States.Add(new State() { Name = "North Carolina", Abbreviation = "NC" });
            States.Add(new State() { Name = "North Dakota", Abbreviation = "ND" });
            States.Add(new State() { Name = "Ohio", Abbreviation = "OH" });
            States.Add(new State() { Name = "Oklahoma", Abbreviation = "OK" });
            States.Add(new State() { Name = "Oregon", Abbreviation = "OR" });
            States.Add(new State() { Name = "Pennsylvania", Abbreviation = "PA" });
            States.Add(new State() { Name = "Rhode Island", Abbreviation = "RI" });
            States.Add(new State() { Name = "South Carolina", Abbreviation = "SC" });
            States.Add(new State() { Name = "South Dakota", Abbreviation = "SD" });
            States.Add(new State() { Name = "Tennessee", Abbreviation = "TN" });
            States.Add(new State() { Name = "Texas", Abbreviation = "TX" });
            States.Add(new State() { Name = "Utah", Abbreviation = "UT" });
            States.Add(new State() { Name = "Vermont", Abbreviation = "VT" });
            States.Add(new State() { Name = "Virginia", Abbreviation = "VA" });
            States.Add(new State() { Name = "Washington", Abbreviation = "WA" });
            States.Add(new State() { Name = "West Virginia", Abbreviation = "WV" });
            States.Add(new State() { Name = "Wisconsin", Abbreviation = "WI" });
            States.Add(new State() { Name = "Wyoming", Abbreviation = "WY" });
        }
    }
}
