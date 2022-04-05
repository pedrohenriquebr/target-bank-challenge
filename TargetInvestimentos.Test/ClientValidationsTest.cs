using TargetInvestimentos.Domain.Validations;
using Xunit;

namespace TargetInvestimentos.Test
{
    public class ClientValidationsTest
    {
        [Fact]
        public void TestValidateCPF()
        {
            Assert.False(ClientValidations.ValidateCPF("123.123.123-99"));
            Assert.False(ClientValidations.ValidateCPF("123.123.123-"));
            Assert.False(ClientValidations.ValidateCPF("123.123.  -"));
            Assert.False(ClientValidations.ValidateCPF("123.undefined.  -"));
            Assert.False(ClientValidations.ValidateCPF("###.undefined.  -"));
            Assert.False(ClientValidations.ValidateCPF(".undefined.  -"));
            Assert.False(ClientValidations.ValidateCPF("123.123.12399"));
            Assert.False(ClientValidations.ValidateCPF("vv"));
        }

        [Fact]
        public void TestValidateCEP()
        {
            //é o cep de onde moro
            Assert.True(ClientValidations.ValidateCEP("20760-721"));
            Assert.False(ClientValidations.ValidateCEP("2g760-721"));
            Assert.False(ClientValidations.ValidateCEP("abcd-721"));
            Assert.False(ClientValidations.ValidateCEP("abcd-"));
            Assert.False(ClientValidations.ValidateCEP("...-"));
            Assert.False(ClientValidations.ValidateCEP("20760721"));
        }
    }
}