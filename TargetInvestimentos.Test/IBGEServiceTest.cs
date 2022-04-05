using TargetInvestimentos.Api.Services;
using TargetInvestimentos.Domain.Interfaces;
using TargetInvestimentos.Domain.Validations;
using Xunit;

namespace TargetInvestimentos.Test
{
    public class IBGEServiceTest
    {

        private IIBGEService service;

        public IBGEServiceTest()
        {
            service = new IBGEService();
        }


        [Fact]
        public async void Returns_AllStates()
        {
            var list = await service.GetAllStates();

            Assert.True(list.Count > 0);
        }
    }
}