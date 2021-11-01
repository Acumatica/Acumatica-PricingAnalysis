using Core.Login;
using Core.TestExecution;
using TestFreightPrice.Extensions.ManageFinancialPeriods;

namespace TestFreightPrice.Tests
{
    public class TestBase : Check
    {
        protected TestBase()
        { }

        public string Prefix = "TEST";
        public override void BeforeExecute()
        {
            PxLogin.LoginToDestinationSite();
        }


    }
}
