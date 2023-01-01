namespace UpSchool_ChainofResponsibility.ChainofResponsibility
{
    public class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee supervisor)
        {
            this.NextApprover = supervisor;
        }
        //public abstract ProcessRequest();
    }
}
