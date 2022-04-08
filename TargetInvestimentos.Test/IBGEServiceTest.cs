using System.Collections.Generic;
using TargetInvestimentos.Api.Services;
using TargetInvestimentos.Domain.Entities;
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
            var list = (List<State>) await service.GetAllStates();

            Assert.True(list.Count > 0);
            Assert.StrictEqual("Rondônia", list[0].Nome);
            Assert.StrictEqual("RO", list[0].Sigla);
        }
    }
}