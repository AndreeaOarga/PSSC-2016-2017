using Models.Generics;

namespace Models.Subject
{
    public class SubjectInformation
    {
        private string p;

        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Professor.Professor Professor { get; internal set; }
        public Proportion ActivityProportion { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        {
            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity, Professor.Professor professor) 
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }

        public SubjectInformation(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public void SetProfessor(Professor.Professor professor)
        {
            Professor = professor;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            ActivityProportion = proportion;
        }
    }
}
