using Xunit;
public class TestLastNumberCalculation {


    [Fact]
    public void TestValidateSocialSecurityNumber_Valid() {
        string personNr = "9001152397";                     

        bool result = LastNumberCalculation.ValidateSocialSecurityNumber(personNr);

        Assert.Equal(true, result);
    }
        [Fact]
    public void TestValidateSocialSecurityNumber_ReturnFalse() {
        string personNr = "9502141635";

        bool result = LastNumberCalculation.ValidateSocialSecurityNumber(personNr);

        Assert.Equal(false, result);
    }
}
